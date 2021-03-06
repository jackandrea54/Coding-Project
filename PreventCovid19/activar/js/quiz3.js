(function(){
    // Functions
    function buildQuiz(){
      // variable to store the HTML output
      const output = [];
  
      // for each question...
      myQuestions.forEach(
        (currentQuestion, questionNumber) => {
  
          // variable to store the list of possible answers
          const answers = [];
  
          // and for each available answer...
          for(letter in currentQuestion.answers){
  
            // ...add an HTML radio button
            answers.push(
              `<label>
                <input type="radio" name="question${questionNumber}" value="${letter}">
                ${letter} :
                ${currentQuestion.answers[letter]}
              </label>`
            );
          }
  
          // add this question and its answers to the output
          output.push(
            `<div class="slide">
              <div class="question"> ${currentQuestion.question} </div>
              <div class="answers"> ${answers.join("")} </div>
            </div>`
          );
        }
      );
  
      // finally combine our output list into one string of HTML and put it on the page
      quizContainer.innerHTML = output.join('');
    }
  
    function showResults(){
  
      // gather answer containers from our quiz
      const answerContainers = quizContainer.querySelectorAll('.answers');
  
      // keep track of user's answers
      let numCorrect = 0;
  
      // for each question...
      myQuestions.forEach( (currentQuestion, questionNumber) => {
  
        // find selected answer
        const answerContainer = answerContainers[questionNumber];
        const selector = `input[name=question${questionNumber}]:checked`;
        const userAnswer = (answerContainer.querySelector(selector) || {}).value;
  
        // if answer is correct
        if(userAnswer === currentQuestion.correctAnswer){
          // add to the number of correct answers
          numCorrect++;
  
          // color the answers green
          answerContainers[questionNumber].style.color = 'lightgreen';
        }
        // if answer is wrong or blank
        else{
          // color the answers red
          answerContainers[questionNumber].style.color = 'red';
        }
      });
  
      // show number of correct answers out of total
      resultsContainer.innerHTML = `${numCorrect} out of ${myQuestions.length}`;
    }
  
    function showSlide(n) {
      slides[currentSlide].classList.remove('active-slide');
      slides[n].classList.add('active-slide');
      currentSlide = n;
      if(currentSlide === 0){
        previousButton.style.display = 'none';
      }
      else{
        previousButton.style.display = 'inline-block';
      }
      if(currentSlide === slides.length-1){
        nextButton.style.display = 'none';
        submitButton.style.display = 'inline-block';
      }
      else{
        nextButton.style.display = 'inline-block';
        submitButton.style.display = 'none';
      }
    }
  
    function showNextSlide() {
      showSlide(currentSlide + 1);
    }
  
    function showPreviousSlide() {
      showSlide(currentSlide - 1);
    }
  
    // Variables
    const quizContainer = document.getElementById('quiz');
    const resultsContainer = document.getElementById('results');
    const submitButton = document.getElementById('submit');
    const myQuestions = [
      {
        question: "C??u 1: Virus Corona l??y lan nh?? th??? n??o?",
        answers: {
          a: "Virus n??y ban ?????u xu???t hi???n t??? ngu???n th???c v???t, kh??ng c?? kh??? n??ng l??y lan t??? ng?????i sang ng?????i",
          b: "Virus n??y ban ?????u xu???t hi???n t??? ngu???n ?????ng v???t nh??ng c?? kh??? n??ng l??y lan t??? ng?????i sang ng?????i th??ng qua ti???p x??c v???i d???ch c?? th??? c???a ng?????i b???nh (ch???t th???i; n?????c b???t;...)",
        },
        correctAnswer: "b"
      },
      {
        question: "C??u 2: C??c kh??ng gian n??o c?? nguy c?? l??y nhi???m virus cao h??n?",
        answers: {
          a: "M???i n??i nh?? nhau",
          b: "N??i ch???t h???p ho???c t???p trung ????ng ng?????i",
        },
        correctAnswer: "b"
      },
      {
        question: "C??u 3: T??nh ?????n th???i ??i???m hi???n t???i, ???? c?? thu???c ?????c hi???u ph??ng v?? ??i???u tr??? virus Corona m???i ch??a?",
        answers: {
          a: "???? c??",
          b: "Ch??a c??",
        },
        correctAnswer: "b"
      },
      {
        question: "C??u 4: Ng?????i kh???e m???nh b??nh th?????ng ??t c?? nguy c?? l??y nhi???m h??n ng?????i y???u kh??ng?",
        answers: {
          a: "C??",
          b: "Kh??ng",
        },
        correctAnswer: "b"
      },
      {
        question: "C??u 5: Mi???n Nam c?? ??t nguy c?? l??y lan d???ch h??n mi???n b???c kh??ng?",
        answers: {
          a: "Ch??a c?? b???ng ch???ng ????? so s??nh",
          b: "Mi???n Nam ??t d???ch h??n v?? c??ch xa Trung Qu???c",
        },
        correctAnswer: "a"
      },
      {
        question: "C??u 6: Ti??m v???c xin c??m th?????ng c?? ng??n ng???a l??y nhi???m Virus Corona kh??ng?",
        answers: {
          a: "C?? hi???u qu???",
          b: "Kh??ng ng??n ng???a ???????c",
        },
        correctAnswer: "b"
      },
      {
        question: "C??u 7: B??i d???u v???ng c?? th??? c???n tr??? virus corona x??m nh???p c?? th??? kh??ng?",
        answers: {
          a: "Kh??ng",
          b: "C??",
        },
        correctAnswer: "a"
      },
      {
        question: "C??u 8: Th???i gian ??? b???nh c???a Virus Corona l?? bao nhi??u ng??y?",
        answers: {
          a: "T??? 2-12.5 ng??y",
          b: "T??? 5-7 ng??y",
        },
        correctAnswer: "a"
      },
      {
        question: "C??u 9: S???t cao (tr??n 40 ?????) nh??ng kh??ng ??au h???ng, ???? c?? ph???i tri???u ch???ng c???a virus Corona hay kh??ng?",
        answers: {
          a: "Ch???c ch???n l?? kh??ng",
          b: "C?? th??? c??. N??n ?????n c?? s??? y t??? g???n nh???t ????? ???????c kh??m",
        },
        correctAnswer: "b"
      },
      {
        question: "C??u 10: Theo b???n, kho???ng c??ch an to??n khi ??? c???nh ng?????i ho, s???t nghi nhi???m Covid-19 l?? bao nhi??u?",
        answers: {
          a: "??t nh???t 1m",
          b: "??t nh???t 2m",
        },
        correctAnswer: "b"
      }
    ];
  
    // Kick things off
    buildQuiz();
  
    // Pagination
    const previousButton = document.getElementById("previous");
    const nextButton = document.getElementById("next");
    const slides = document.querySelectorAll(".slide");
    let currentSlide = 0;
  
    // Show the first slide
    showSlide(currentSlide);
  
    // Event listeners
    submitButton.addEventListener('click', showResults);
    previousButton.addEventListener("click", showPreviousSlide);
    nextButton.addEventListener("click", showNextSlide);
  })();
  