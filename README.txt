Welcome to the Silverlight Calculator.

This application was created for the simple reason: JAVASCRIPT CANNOT DO MATH

What this really means is that the basic numeric type in JavaScript is floating point. 

Floating Point math is very difficult if not impossible to use when doing basic financial calculations. 

Like Adding, Subtracting, Multiplying and Dividing dollar amounts.

This application solves this by creating a basic calculator that provides 4 basic calculations:

Add(number1, number2)
Subtract(number1, number2)
Multiply(number1, number2)
Divide(number1, number2)

This application is written in C# and deployed via a Silverlight Plugin.

There is a fully functional example in the WebSample Folder.

You can also access a demo of this application at calculator.dashpoint.com

Using this application is very simple. You just add an OBJECT tag in your web page pointing at the SilverlightCalculator.xap file.

Then using Jquery (or whatever JavaScript library you use) grab a handle to the plug in and call the operator you need for math calculations.

<object id="calculator" data="data:application/x-silverlight-2," type="application/x-silverlight-2" width="0%" height="0%">
	<param name="source" value="Silverlight/SilverlightCalculator.xap"/>
	<param name="background" value="white" />
	<param name="minRuntimeVersion" value="3.0.40818.0" />
	<param name="autoUpgrade" value="true" />
	<a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40818.0" style="text-decoration:none">
	<img src="http://go.microsoft.com/fwlink/?LinkId=108181" alt="Get Microsoft Silverlight" style="border-style:none"/>
</object>


function getCalculatorHandle() {
    // code to grab a handle to the silverlight calculator
    var returnValue = document.getElementById("calculator").content.calculator;
    return returnValue;
}


// sample call to the Add Function
function addNumbers(){
  var factor_1 = $("#addNumber1").val();
  var factor_2 = $("#addNumber2").val();
  var calc = getCalculatorHandle().Add(factor_1,factor_2);
  alert(calc);
}