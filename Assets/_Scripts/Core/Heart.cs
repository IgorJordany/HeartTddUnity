using UnityEngine.UI;

namespace Assets._Scripts.Core
{
    internal class Heart
    {
        private const float PedacoCoracao = 0.25f;

        public Image HeartImage { get; }

        public Heart(Image image)
        {
            HeartImage = image;
        }

        public void RegenerarCoracao(int quantidade)
        {
            HeartImage.fillAmount += quantidade * PedacoCoracao;
        }
        
        public void DegradarCoracao(int quantidade)
        {
            HeartImage.fillAmount -= quantidade * PedacoCoracao;
        }
    }
}
