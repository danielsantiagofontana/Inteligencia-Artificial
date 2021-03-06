﻿//Título: Microredes(mRedes)
//Subtítulo: V3.1.3.2
//Autor: Amro Xpike(propietario del canal de Youtube “Xpikuos”)
//Licencia:
//Este trabajo está licenciado bajo la licencia de Atribución-NoComercial-CompartirIgual 4.0 Internacional(CC BY-NC-SA 4.0)
//Para ver una copia de esta licencia, visita
//https://creativecommons.org/licenses/by-nc-sa/4.0/deed.es

namespace XudonV2NetStandard.Structure
{
    public class ORLayer : Layer
    {
        private bool _newPattern;

        public ORLayer(uint layerNumber) : base(layerNumber)
        { }

        public void GenerateNewPattern()
        {
            //TODO
            _newPattern = true;
        }

        public override void MethodToExecuteAfterReadingAllInputData() //Diastole
        {

        }

        public override void MethodToExecuteAfterSendingAllInputData() //Systole
        {

        }
    }
}
