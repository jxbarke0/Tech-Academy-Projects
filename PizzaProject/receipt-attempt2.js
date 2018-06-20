var theForm = document.forms["allmenu"];

var size_prices = new Array ();
size_prices["Personal Pizza"]=6;
size_prices["Medium"]=10;
size_prices["Large"]=14;
size_prices["Extra Large"]=16;

// getSizePrice() finds the price based on the size of the pizza
// the following goes through the radio buttons to see which one is checked

function getSizePrice() {
	var sizeRadio = document.getElementsByName('Size');

	for(var i = 0; i < sizeRadio.length; i++) {
		if(sizeRadio[i].checked) {
			user_input = sizeRadio[i].value;
		}
	}
	return size_prices[user_input];
}



function getMeatPrice() {
	var meatPrice = 0;
	var addMeat = [];
	var meatArray = document.getElementsByClassName("meat");
	for(var j = 0; j < addMeat.length; j++) {
		if(addMeat[j].checked) {
			addMeat.push(meatArray[j].value);
		}
	}
	var meatCount = addMeat.length;
	if (meatCount > 1) {
		meatPrice = (meatCount - 1);
	} else {
		meatPrice = 0;
	}
	return meatPrice;
}
	
function getTotal() {
	var total = getSizePrice() + getMeatPrice() + getVeggiesPrice() + getCheesePrice() + getCrustPrice();
	var totalEl = document.getElementById('totalPrice');
	
	document.getElementById('totalPrice').innerHTML = "$"+ total;
	totalEl.style.display = 'block';
}
