unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Button2: TButton;
    Label1: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
    vetor : array of string;
    v_guardando_resp : boolean;
    v_resp : string;
    v_pos : integer;
    v_sorteado : integer;

    procedure Inicia;
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
begin
   setlength(vetor,5);
   vetor[0] := 'Oh computador de sabedoria!';
   vetor[1] := 'Grande máquina do saber, me diga';
   vetor[2] := 'Seu computador de araque, responda agora';
   vetor[3] := 'Seu monte de bugigangas, me responda ja';
   vetor[4] := 'Computador que tudo sabe, me diga agora';

   Inicia;
end;

procedure TForm1.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
  if key =#13 then begin
     v_guardando_resp := false;
     key := #0;
  end
  else if v_guardando_resp then begin
     v_resp := v_resp + key;

     key := vetor[v_sorteado][v_pos];
     inc(v_pos);
  end;
end;

procedure TForm1.Inicia;
begin
  Randomize;
  v_sorteado := random( length(vetor ) );
  v_pos := 0;
  v_resp := '';
  v_guardando_resp := true;
  Edit1.clear;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  showmessage(v_resp);
  Inicia;
end;

end.
