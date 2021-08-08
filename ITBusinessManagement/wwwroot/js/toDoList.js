/*!
  * IT Business Management v1.0.0
  * Copyright 2019-2021 The MSOFTWARE(https://www.vnexus.com/)
  * Licensed (https://www.vnexus.com)
  */
/* ----------------------------------------------------- */


var taskTitle = document.getElementById("taskTitle");
var 
var informationText = document.getElementById("informationText", "show");
var cardText = document.getElementById("informationToWork", "workName");

var cardInformation = informationText == cardText;
var cardTitle = workName == taskTitle;

// Show button and modal variables.
var infoTextCard = show; // Show button id.

var infoTitleCard = workTitle; // Card title id.

var modalInformationMore = show == workTitle;


//To-do-list Modal.

$('#addTaskModal').on('show.bs.modal', function (event) {

    var button = $(event.relatedTarget) // Button that triggered the modal
    var recipient = button.data('whatever') // Extract info from data-* attributes
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)

    modal.find('.modal-title').text(recipient)

    modal.find('.modal-body input').val(recipient)

});

//Create to To-do card item dragdrop function.

function CardAdd(onClick) {

    var toDoCard = document.createElementByClassName("CARD");

    toDoCard.innerHTML = getElementById("taskName") == cardTitle;
    toDoCard.innerHTML = getElementById("informationText") == cardInformation;

    document.body.appendChild("TDoCard");

  
}

//To-Do close function.
var ua = n(151),
    ha = n.n(ua);
window.dragula = ha.a;
n(93);
var pa = n(108),
    fa = n.n(pa);
document.addEventListener("DOMContentLoaded", (function () {
    fa.a.replace()
})),
    window.feather = fa.a;
var ga = n(77),
    ma = n.n(ga);
window.moment = ma.a;
n(175),
    n(185);
var va = n(78),
    ba = n.n(va),
    ya = (n(186), n(131), n(196), n(198), n(200), n(203), n(204), n(213), n(109)),
    xa = n.n(ya),
    _a = n(110),
    wa = n.n(_a),
    Sa = n(152),
    Ca = n.n(Sa),
    ka = n(153),
    Da = (n(214), n(216), n(144), n(219), n(220), null),
    Ta = null;

function Ea() {
    if (null === Da) {
        if ("undefined" == typeof document)
            return Da = 0;
        var t = document.body,
            e = document.createElement("div");
        e.classList.add("simplebar-hide-scrollbar"),
            t.appendChild(e);
        var n = e.getBoundingClientRect().right;
        t.removeChild(e),
            Da = n
    }
    return Da
}

//Add to-do card function.

$(document).ready(function () {

    classnames();
    //call dragula

    dragula([
        document.getElementById('tasks-upcoming'),
        document.getElementById('tasks-progress'),
        document.getElementById('tasks-completed'),
        document.getElementById('skill'),
    ]).on('drop', function (el) {
        //change classes depending on column
        classnames();
    });


    //static adding of values

    $(".submit").click(function () {
        var getvalue1 = document.getElementById("taskName"), //task titile.
            getvalue2 = document.getElementById("informationText"), //task information.

            getvalue3 = document.getElementById("skill") //personal.
        
            getvalue4 = document.getElementById("textBody"), //to-do text modal.

            a = getvalue1.value,
            b = getvalue2.value,
            c = getvalue3.value,
            d = getvalue4.value;

        var today = new Date();
        $(".drag-1").append("<div class='card mb-3 bg-light cursor-grab border drag-1'><div class='card-body p-3'><input type='checkbox'arial-label='completed' checked='' class='checkbox' name='' value=''/><p id='workTitle1'><a id='workInfo'>" + a + "<p  id='worktitle'></p>" + b + "<img id='userName' width='32' height='32' class='rounded - circle' alt='P-'>" + c + "<a id='workShow'>" + d + "<div id='textBody' class='modal-body'></a></div></div>");

        //add class to checked items

        $('input:checkbox.checkbox').change(function () {
            if ($(this).is(":checked")) {
                $(this).parents(".box").addClass("checked");
            } else {
                $(this).parents(".box").removeClass("checked");
            }
        });
    });


    //add class to checked items

    $('input:checkbox.checkbox').change(function () {
        if ($(this).is(":checked")) {
            $(this).parents(".box").addClass("checked");
        } else {
            $(this).parents(".box").removeClass("checked");
        }
    });
});


//User tag function.


    var userTag = new Bloodhound({
        datumTokenizer: Bloodhound.tokenizers.obj.whitespace('text'),
  queryTokenizer: Bloodhound.tokenizers.whitespace,
  prefetch: 'lib/user.json'
});
user.initialize();

var elt = $('input');
elt.tagsinput({
        tagClass: function(item) {
    switch (item.continent) {
      case 'Europe'   : return 'label label-primary';
      case 'America'  : return 'label label-danger label-important';
      case 'Australia': return 'label label-success';
      case 'Africa'   : return 'label label-default';
      case 'Asia'     : return 'label label-warning';
    }
  },
  itemValue: 'value',
  itemText: 'text',
  typeaheadjs: {
        name: 'user',
    displayKey: 'text',
    source: cities.ttAdapter()
  }
});
elt.tagsinput('add', {"value": 1 , "text": "Amsterdam"   , "continent": "Europe"    });
elt.tagsinput('add', {"value": 4 , "text": "Washington"  , "continent": "America"   });
elt.tagsinput('add', {"value": 7 , "text": "Sydney"      , "continent": "Australia" });
elt.tagsinput('add', {"value": 10, "text": "Beijing"     , "continent": "Asia"      });
elt.tagsinput('add', {"value": 13, "text": "Cairo"       , "continent": "Africa"    });



