var currenttime = new Date();
hours = currenttime.getHours();
minutes = currenttime.getMinutes();

if (minutes < 10) {
    console.log(hours + ':0' + minutes);
} else {
    console.log(hours + ':' + minutes);

}