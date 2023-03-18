// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/**Bloco global*/
//showSlides(slideIndex);
showSlidesAutomatic();

// Controle de Próximo/Anterior
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Controles de imagem em miniatura
function currentSlide(n) {
  showSlides(slideIndex = n);
}

// Função para exibir as imagens
function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) { slideIndex = 1 }
  if (n < 1) { slideIndex = slides.length }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex - 1].style.display = "block";
  dots[slideIndex - 1].className += " active";
}

function showSlidesAutomatic() {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex2++;
  if (slideIndex2 > slides.length) { slideIndex2 = 1 }

  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }

  slides[slideIndex2 - 1].style.display = "block";
  dots[slideIndex2 - 1].className += " active";
  setTimeout(showSlidesAutomatic, 2000);
}
function validaemail(){
  var campoemail = document.getElementById("Email")
  var valoremail = Email.value;
  if(valoremail.length < 10) {
      if (valoremail == "" || valoremail == null ) {
          alert("Campo de E-mail não pode estar em branco!");
          return false;
      } else {
          alert("E-mail precisa ter ao menos 10 caracteres.");
          return false;
      }

  } else {
      return true;
  }
}
function validatelefone(){
  var campotelefone = document.getElementById("Telefone")
  var valortelefone = Telefone.value;
  if(valortelefone.length < 12) {
      if (valortelefone == "" || valortelefone == null ) {
          alert("Campo de telefone não pode estar em branco!");
          return false;
      } else {
          alert("Telefone precisa ter ao menos 12 caracteres.");
          return false;
      }

  } else {
      return true;
  }
}
function mostraDica()
{
  document.getElementById("dicaTexto").style.display = "inline";
}
function escondeDica()
{
  document.getElementById("dicaTexto").style.display = "none";
}
              
/**Bloco global*/
document.getElementById("dicaTexto").style.display = "none";
var elForm = document.getElementById("formPrincipal");
elForm.onsubmit = validaemail;
elForm.onsubmit = validatelefone;
var slideIndex = 1;
var slideIndex2 = 0;