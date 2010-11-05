function main(){
   $("#cmdAddNumbers").click(addNumbers);
   $("#cmdMultiplyNumbers").click(multiplyNumbers);
   $("#cmdDivideNumbers").click(divideNumbers);
   $("#cmdSubtractNumbers").click(subtractNumbers);
}

function getCalculatorHandle() {
    // code to grab a handle to the silverlight calculator
    var returnValue = document.getElementById("calculator").content.calculator;
    return returnValue;
}

function addNumbers(){
  var factor_1 = $("#addNumber1").val();
  var factor_2 = $("#addNumber2").val();
  var calc = getCalculatorHandle().Add(factor_1,factor_2);
  alert(calc);
}


function multiplyNumbers(){
  var factor_1 = $("#addNumber1").val();
  var factor_2 = $("#addNumber2").val();
  var calc = getCalculatorHandle().Multiply(factor_1,factor_2);
  alert(calc);
}


function divideNumbers(){
  var factor_1 = $("#addNumber1").val();
  var factor_2 = $("#addNumber2").val();
  var calc = getCalculatorHandle().Divide(factor_1,factor_2);
  alert(calc);
}


function subtractNumbers(){
  var factor_1 = $("#addNumber1").val();
  var factor_2 = $("#addNumber2").val();
  var calc = getCalculatorHandle().Subtract(factor_1,factor_2);
  alert(calc);
}


