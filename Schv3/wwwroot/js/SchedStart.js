function checkGroupOrFio(val) {
    console.log(val);
    if (val == "") {
        $("#week").disabled = true;
        $("#week").value = "";
        $("#this_week").disabled = true;
        $("#next_week").disabled = true;
        $("#show_schedule").disabled = true;
    }
    else {
        $("#week").removeAttr("disabled");
        $("#this_week").removeAttr("disabled");
        $("#next_week").removeAttr("disabled");
    }
}

function checkWeek(val) {
    console.log(val);
    if (val == "") {
        $("#search").disabled = true;;
    }
    else {
        $("#show_schedule").removeAttr("disabled");
    }
}

function getWeek(val) {
    let thisYear = new Date().getFullYear();
    let start = new Date('08/28/' + thisYear);
    let today = new Date();
    const week = (start, today) => {
        let difference = today.getTime() - start.getTime();
        let total_week = Math.ceil(difference / (1000 * 3600 * 24 * 7));
        return total_week + val;
    }
    document.getElementById("week").value = week(start, today) + " неделя";
    $("#show_schedule").removeAttr("disabled");
    console.log(week(start, today));
}

function goToSchedule() {
    window.location = "Schedule";
}

function goToSearch() {
    window.location = "Search";
}