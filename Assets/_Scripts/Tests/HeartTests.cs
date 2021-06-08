using Assets._Scripts.Core;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Tests
{
    public class HeartTests
    {
        [TestFixture]
        class HeartRegenerate
        {
            private Image _image;
            private Heart _heart;

            [SetUp]
            public void RunBeforeEveryTest()
            {
                _image = new GameObject().AddComponent<Image>();
                _heart  = new Heart(_image);
            }
            
            [Test]
            public void Regenera_coracao_vazio_uma_parte()
            {
                _heart.HeartImage.fillAmount = 0;

                _heart.RegenerarCoracao(1);

                Assert.AreEqual(0.25f, _heart.HeartImage.fillAmount);
            }

            [Test]
            public void Regenera_coracao_vazio_duas_partes()
            {
                _heart.HeartImage.fillAmount = 0;

                _heart.RegenerarCoracao(1);
                _heart.RegenerarCoracao(1);

                Assert.AreEqual(0.5f, _heart.HeartImage.fillAmount);
            }

            [Test]
            public void Regenera_coracao_completo()
            {
                _heart.HeartImage.fillAmount = 0;

                _heart.RegenerarCoracao(4);

                Assert.AreEqual(1f, _heart.HeartImage.fillAmount);
            }
        }

        [TestFixture]
        class HeartDamage
        {
            private Image _image;
            private Heart _heart;

            [SetUp]
            public void RunBeforeEveryTest()
            {
                _image = new GameObject().AddComponent<Image>();
                _heart = new Heart(_image);
            }

            [Test]
            public void Toma_um_dano_com_coracao_cheio()
            {
                _heart.HeartImage.fillAmount = 1;

                _heart.DegradarCoracao(1);

                Assert.AreEqual(0.75f, _heart.HeartImage.fillAmount);
            }

            [Test]
            public void Toma_dois_danos_coracao_cheio()
            {
                _heart.HeartImage.fillAmount = 1;

                _heart.DegradarCoracao(1);
                _heart.DegradarCoracao(1);

                Assert.AreEqual(0.5f, _heart.HeartImage.fillAmount);
            }

            [Test]
            public void Toma_dano_maximo()
            {
                _heart.HeartImage.fillAmount = 1;

                _heart.DegradarCoracao(4);

                Assert.AreEqual(0f, _heart.HeartImage.fillAmount);
            }
        }
    }
}
