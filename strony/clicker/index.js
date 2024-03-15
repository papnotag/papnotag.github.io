function operate(type) {
    let amount = parseInt(document.querySelector('#amount').innerHTML);
    
    if (type == '-' && amount > 0) amount--;
    if (type == '+') amount++;

    document.querySelector('#amount').innerHTML = amount;
}