using System;

namespace estruturadoprograma
{

    public class Pilha
    {
        posicao primeiro;

        public void Empilha(object item)
        {
            primeiro = new posicao(primeiro,item);
        }

        public object desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException();
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }   

        class posicao 
        {
            public posicao proximo;
            public object item;
            public posicao(posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }   
}