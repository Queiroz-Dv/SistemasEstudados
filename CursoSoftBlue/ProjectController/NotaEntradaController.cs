using ProjectPersistence;
using System.Collections;
using System.Collections.Generic;
using Treinojunior.ProjectModel;

namespace ProjectController
{
    public class NotaEntradaController
    {
        private Repository repository = new Repository();

        public InputNota Insert(InputNota nota)
        {
            return this.repository.InsertNota(nota);
        }

        public void Remove(InputNota nota)
        {
            this.repository.RemoverNotas(nota);
        }

        public IList<InputNota> GetAll()
        {
            return this.repository.GetAllNotas();
        }

        public InputNota Update(InputNota nota)
        {
            return this.repository.UpdateNota(nota);
        }
    }
}
