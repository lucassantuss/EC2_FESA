using HangmanGame.ExceptionHandling;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HangmanGame.Generic
{
    public class Collection<T> : IEnumerable<T>
    {
        #region Properties
        protected T[] Array { get; set; }
        public int Count { get { return Array.Length; } }
        protected int LastIndex { get { return Count - 1; } }
        public T this[int index]
        {
            get { try { return Array[index]; } catch (Exception e) { ErrorLog.Append(e); return default(T); } }
            set { try { Array[index] = value; } catch (Exception e) { ErrorLog.Append(e); } }
        }
        #endregion

        #region Methods

        #region ctor
        /// <summary>
        /// ctor.
        /// </summary>
        public Collection()
        {
            Array = new T[0];
        }
        #endregion

        /// <summary>
        /// Adiciona à coleção o item desejado.
        /// </summary>
        /// <param name="item">Item a ser adicionado.</param>
        public void Add(T item)
        {
            RecreateArray(Count + 1);
            Array[LastIndex] = item;
        }

        /// <summary>
        /// Remove da coleção o item desejado.
        /// </summary>
        /// <param name="item">Item a ser removido.</param>
        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
                if (item.Equals(Array[i]))
                {
                    RemoveAt(i);
                    return;
                }
        }

        /// <summary>
        /// Remove da coleção todas as instâncias do item desejado.
        /// </summary>
        /// <param name="item">Item a ser removido.</param>
        public void RemoveAll(T item)
        {
            for (int i = 0; i < Count;)
                if (item.Equals(Array[i]))
                    RemoveAt(i);
                else
                    i++;
        }

        /// <summary>
        /// Remove da coleção um item no índice desejado.
        /// </summary>
        /// <param name="index">Índice desejado do item a ser removido.</param>
        public void RemoveAt(int index)
        {
            RecreateArray(Count - 1, Array[index], 1);
        }

        /// <summary>
        /// Recria o array da forma desejada
        /// </summary>
        /// <param name="size">Novo tamanho da coleção</param>
        /// <param name="exclusion">Item a ser excluído da coleção</param>
        /// <param name="exclusionThreshold">Limite de exclusão de itens da coleção</param>
        protected void RecreateArray(int newSize, T exclusion = default(T), int exclusionThreshold = 0)
        {
            try
            {
                T[] newArray = new T[newSize];

                for (int i = 0, exclusionCount = 0; i < Count; i++)
                    if (Array[i].Equals(exclusion))
                    {
                        if (exclusionCount < exclusionThreshold)
                            exclusionCount++;
                        else
                            newArray[i - exclusionCount] = Array[i];
                    }
                    else if (!Array[i].Equals(exclusion))
                    {
                        if (exclusionCount == 0)
                            newArray[i] = Array[i];
                        else
                            newArray[i - exclusionCount] = Array[i];
                    }

                Array = newArray;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Limpa todos os itens do array interno.
        /// </summary>
        public void Clear()
        {
            Array = new T[0];
        }

        /// <summary>
        /// Retorna o array interno da coleção.
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            return Array;
        }

        /// <summary>
        /// Método responsável por retornar uma instância de objeto a cada iteração.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Array)
                if (item != null && !item.Equals(default(T)))
                    yield return item;
        }

        /// <summary>
        /// Método responsável por retornar uma instância do objeto.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
