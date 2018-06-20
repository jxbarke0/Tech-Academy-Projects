
// var itemArray = new Array(); //holds the names of all ordered items for display on the receipt
// var priceArray = new Array(); // holds the prices of all ordered items for display on the receipt
var itemArray = [];
var priceArray = [];
var totalTotal = 0;

function getSize(itemArray, priceArray) {
	var sizeTotal = 0;
	var sizeArray = [];
	var sizeArray = document.getElementsByClassName("size");
	for (var i = 0; i < sizeArray.length; i++) {
	if (sizeArray[i].checked) {
		var selectedSize = sizeArray[i].value;
		}
	}
	if (selectedSize === "Personal Pizza") {
		sizeTotal = 6;
		itemArray.push("Personal Pizza");
		priceArray.push(6+".00");
	} else if (selectedSize === "Medium") {
		sizeTotal = 10;
		itemArray.push("Medium");
		priceArray.push(10+".00");
	} else if (selectedSize === "Large") {
		sizeTotal = 14;
		itemArray.push("Large");
		priceArray.push(14+".00");
	} else if (selectedSize === "Extra Large") {
		sizeTotal = 16;
		itemArray.push("Extra Large");
		priceArray.push(16+".00");
	}
	totalTotal =  0; //carries a running total from function to function
	totalTotal = sizeTotal + totalTotal;
	getMeat(itemArray, priceArray, totalTotal);

};
	

console.log(itemArray);
console.log(priceArray);

function getMeat(itemArray, priceArray, totalTotal) {
	var meatTotal = 0;
	var meatArray = document.getElementsByClassName("meat");
	var selectedMeat = []; //holds all selected meat items
	for (var i = 0; i < meatArray.length; i++) {
		if (meatArray[i].checked) {
			selectedMeat.push(meatArray[i].value);
		}
	}
	var meatCount = selectedMeat.length;
	if (meatCount > 1) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
	}
	totalTotal = meatTotal + totalTotal; //carries a running total from function to function
	itemArray.push(selectedMeat);
	priceArray.push(meatTotal+".00");
	getVeggie(itemArray, priceArray, totalTotal);
}

console.log(itemArray);
console.log(priceArray);

function getVeggie(itemArray, priceArray, totalTotal) {
	var veggieTotal = 0;
	var veggieArray = document.getElementsByClassName("veggie");
	var selectedVeggies = []; //holds all selected veggies, except pineapple which is gross
	for (var i = 0; i < veggieArray.length; i++) {
		if (veggieArray[i].checked) {
			selectedVeggies.push(veggieArray[i].value);
		}
	}
	var veggieCount = selectedVeggies.length;
	if (veggieCount > 1) {
		veggieTotal = (veggieCount - 1);
	} else {
		veggieTotal = 0;
	}
	totalTotal = veggieTotal + totalTotal; //carries a running total from function to function
	itemArray.push(selectedVeggies);
	priceArray.push(veggieTotal+".00");
	getCheese(itemArray, priceArray, totalTotal);
}

console.log(itemArray);
console.log(priceArray);


function getCheese(itemArray, priceArray, totalTotal) {
	var cheeseTotal = 0;
	var cheeseArray = document.getElementsByClassName("cheese");
	for (var i = 0; i < cheeseArray.length; i++) {
		if (cheeseArray[i].checked) {
			var selectedCheese = cheeseArray[i].value;
		}
	}
	if (selectedCheese === "Cheese") {
		cheeseTotal = 0;
		itemArray.push("Regular Cheese");
		priceArray.push(cheeseTotal+".00");
	}
	else if (selectedCheese === "No Cheese") {
		cheeseTotal = 0;
		itemArray.push("No Cheese");
		priceArray.push(cheeseTotal+".00");
	}
	else if (selectedCheese === "Extra Cheese") {
		cheeseTotal = 3;
		itemArray.push("Extra Cheese!");
		priceArray.push(cheeseTotal+".00");
	}
	totalTotal = cheeseTotal + totalTotal; //carries a running total from function to function
	getSauce(itemArray, priceArray, totalTotal);
}

console.log(itemArray);
console.log(priceArray);
	
function getSauce(itemArray, priceArray, totalTotal) {
	var sauceTotal = 0; //sauce is always zero
	var sauceArray = document.getElementsByClassName("sauce");
	for (var i = 0; i < sauceArray.length; i++) {
		if (sauceArray[i].checked) {
			var selectedSauce = sauceArray[i].value;
		}
	}
	totalTotal = sauceTotal + totalTotal; //carries a running total from function to function
		itemArray.push(selectedSauce);
		priceArray.push(sauceTotal+".00");
	getCrust(itemArray, priceArray, totalTotal)
}

console.log(itemArray);
console.log(priceArray);

function getCrust(itemArray, priceArray, totalTotal) {
	var crustTotal = 0;
	var crustArray = document.getElementsByClassName("crust");
	for (var i = 0; i < crustArray.length; i++) {
		if (crustArray[i].checked) {
			var selectedCrust = crustArray[i].value;
		}
	}
	if (selectedCrust === "Cheese Stuffed Crust") {
		crustTotal = 3;
		itemArray.push(selectedCrust);
		priceArray.push(crustTotal+".00");
	}
	else  {
		crustTotal = 0;
		itemArray.push(selectedCrust);
		priceArray.push(crustTotal+".00");
	}
	totalTotal = crustTotal + totalTotal; //carries a running total from function to function
	document.getElementById("receipt1").innerHTML = itemArray.join("<br>");
	document.getElementById("receipt2").innerHTML = priceArray.join("<br>");
	document.getElementById("finalTotal").innerHTML = "Your total is: $"+totalTotal +".00";
}

console.log(itemArray);
console.log(priceArray);


function getTotal() {
	getSize(itemArray, priceArray);
	console.log(itemArray + " Is the item array");


}
	

console.log(itemArray);
console.log(priceArray);


function clearForm() {
	document.getElementById("allmenu").reset();
	document.getElementById("receipt1").innerHTML = "<br>";
	document.getElementById("receipt2").innerHTML = "<br>";
	document.getElementById("finalTotal").innerHTML = "<br>";
	itemArray = [];
	priceArray = [];
}