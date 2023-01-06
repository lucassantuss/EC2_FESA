import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Estacionamento {

	/**
	 * @param args
	 */
	
	static String ArquivoIn, ArquivoOut;
	static int[][] matriz = new int[0][0];
	static int totalPilhas=0;
	static int totalCaixasAntes1 = 0, totalCaixasApos1 =0, totalDesempilhamentos =0;	 
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ArquivoIn = args[0];
		ArquivoOut = args[1];
		
		Estacionamento c = new Estacionamento();	
		c.ProcessaArquivo();
	}
	
	
	public void ProcessaArquivo()
	{	
		try
		{
			BufferedReader in = new BufferedReader(new FileReader(ArquivoIn));
			String str;
			
			int numeroCaixas=0, pilhasParaProcessar=0, pilhaAtual =0;
			StringBuffer resultado = new StringBuffer();
			int contalinha = 0;
			int qtdeDesmpilha = 0;
			int alturaNumero1 = 0;
			int pilhaQueTemNumero1 = 0;		
			
			Boolean achouNumero1=false;
			
	
			while ((str = in.readLine()) != null) {
				str = str.trim();				
				if (str.equals("0 0"))
					break;
				
				System.out.println(str);
				
				if (contalinha == 0 || pilhasParaProcessar == 0)
				{
					numeroCaixas = Integer.parseInt(str.substring(0, str.indexOf(" ") ));
					pilhasParaProcessar = Integer.parseInt(str.substring(str.indexOf(" ") +1));
					totalPilhas=  pilhasParaProcessar;
					pilhaAtual = 0;					
					qtdeDesmpilha = 0;
					alturaNumero1 = 0;
					totalCaixasApos1 = 0;
					totalCaixasAntes1 = 0;
					totalDesempilhamentos =0;
					matriz = new int[pilhasParaProcessar][numeroCaixas+1];   
					achouNumero1 = false;
				}
				else					
				{					
						String[] dados =str.split(" "); 
						matriz[pilhaAtual][0] = Integer.parseInt(dados [0] );					
						
						for (int n=1; n< dados.length; n++)
						{
							matriz[pilhaAtual][n] = Integer.parseInt(dados[n]);														
							if (matriz[pilhaAtual][n]== 1)
							{
								pilhaQueTemNumero1 = pilhaAtual;
								alturaNumero1 = n; 
								achouNumero1 = true;
							}
							else								
							{ 
								if (achouNumero1 )
									totalCaixasApos1++;
								else
									totalCaixasAntes1++;
							}
							qtdeDesmpilha ++;
						}											
						pilhasParaProcessar--;					
					    pilhaAtual++;
				}				
								
				if (pilhasParaProcessar == 0)
				{
					char ladoComMenos;					
					
					if (totalCaixasAntes1 > totalCaixasApos1)
						ladoComMenos = 'D';
					else
						ladoComMenos = 'E';					
					
					RemoveCaixa(alturaNumero1, pilhaQueTemNumero1, ladoComMenos);
					resultado.append((totalDesempilhamentos -1) + "\r\n" );
					System.out.println("Resultado: " +(totalDesempilhamentos -1) + "\r\n" );
				}					
				contalinha++;				
			}
			
			in.close();
	
			Salva(resultado.toString().trim());
		} 
		catch (IOException e) {
			System.out.println("Erro ao carregar o arquivo!");
			return;
		}	
	}
	
	
	//Lado com menos : 'E'esquero ou 'D'direito
	private static void RemoveCaixa(int nCaixa, int nPilha, char ladoComMenos)
	{	 
	   if (nCaixa != matriz[nPilha][0])
		   RemoveCaixa(nCaixa +1, nPilha , ladoComMenos);
	   if (!LadoLivre(nPilha, nCaixa))
		   if (ladoComMenos == 'D')
		      RemoveCaixa(nCaixa, nPilha +1, ladoComMenos);
		   else
			  RemoveCaixa(nCaixa, nPilha -1, ladoComMenos);
		 				
	   TiraUmaCaixa(nPilha, ladoComMenos);		
	}
	
	
	private static void TiraUmaCaixa( int nPilha, char ladoComMenos)
	{
		totalDesempilhamentos++;
		matriz[nPilha][0] = matriz[nPilha][0] -1;
		if (matriz[nPilha][0] == 0)
			totalPilhas--;	
				
		if (ladoComMenos == 'E')
			totalCaixasAntes1--;
		else
			totalCaixasApos1--;
	}
	
	
	private static boolean LadoLivre(int nPilha, int nCaixa)
	{
		if (nPilha == 0 || nPilha == totalPilhas -1)
		   return true;
		else 
		{
			int alturaCxEsquerda= matriz[nPilha-1][0] ;
			int alturaCxDireita = matriz[nPilha+1][0] ;
			
			return (alturaCxEsquerda < nCaixa || alturaCxDireita < nCaixa );
		}		
	}

	
	private static void Salva(String dados)
	{
		try {
			String arqSaida = ArquivoOut;
			File f = new File(arqSaida);
			if (f.exists())
				f.delete();
			
		    BufferedWriter out = new BufferedWriter(new FileWriter(arqSaida));
		    out.write(dados);
		    out.close();
		} catch (IOException e) {
			System.out.println("Erro ao gravar o arquivo!");
			return;
		}		
	}
	

}
