using ProjectPersistence;
using System;
using System.Collections;
using System.Collections.Generic;
using Treinojunior.ProjectModel;

namespace ProjectController
{
    public class NotaEntradaController
    {
        private Repository repository = new Repository();

        public NotaEntrada Insert(NotaEntrada nota)
        {
            return this.repository.InsertNota(nota);
        }

        public void Remove(NotaEntrada nota)
        {
            this.repository.RemoverNotas(nota);
        }

        public IList<NotaEntrada> GetAll()
        {
            return this.repository.GetAllNotas();
        }

        public NotaEntrada Update(NotaEntrada nota)
        {
            return this.repository.UpdateNota(nota);
        }

        public NotaEntrada GetNotaByID(long? ID)
        {
            return this.repository.GetNotaByID(ID);
        }
    }
}
