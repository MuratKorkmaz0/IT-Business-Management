/*!
  * IT Business Management v1.0.0
  * Copyright 2019-2021 The MSOFTWARE(https://www.msoftware.com/)
  * Licensed (https://www.msoftware.com)
  */
/* ----------------------------------------------------- */

/* Buttons */
document.getElementById("b1").style.display = "none";
document.getElementById("b2").style.display = "none";
document.getElementById("b3").style.display = "none";
document.getElementById("b4").style.display = "none";
document.getElementById("b5").style.display = "none";
//b4.style.display = 'none';
b5.style.display = 'none';
/*
 *
 * b3.style.visibility = 'hidden';
b4.style.visibility = 'hidden';
*/

document.getElementById("add").addEventListener("click", function () {

    var b1 = document.getElementById("b1")

    if (b1.style.display == "none")
    {
        b1.style.display = "block";
        
    }
    else if (b1.style.display = "block")
    {

        var b2 = document.getElementById("b2")
        b2.style.display = "block";

    }
    
    

    if (b2.style.display == "block")
    {
        var b2 = document.getElementById("b2")
        b3.style.display = "block";

    }
    
else if (b3.style.display=="none")
    {
       var b3 = document.getElementById("b3")
        b3.style.display = "block";

    }
    
    /*
    var b4 = document.getElementById("b4")

    if (b4.style.display == "none") {
        b4.style.display = "block";

    }
    else if (b5.style.display = "none")
    {
        b5.style.display="block";
    }

    var b6 = document.getElementById("b6")

    if (b6.style.display == "none") {
        b6.style.display = "block";

    }
    else if (b7.style.display = "none")
    {
       b7.style.display ="block";
    }
    */

});

/* ----------------------------------------------------- */
/* Button ContextMenu */
const attachContextMenu = (() => {
    const contextMenu = document.createElement('ul');

    const hideOnResize = () => hideMenu(true);

    function hideMenu(e) {
        if (e === true || !contextMenu.contains(e.target)) {
            contextMenu.remove();
            document.removeEventListener('click', hideMenu);
            window.removeEventListener('resize', hideOnResize);
        }
    };

    const attachOption = (target, opt) => {
        const item = document.createElement('li');
        item.className = 'context-menu-item';
        item.innerHTML = `<span>${opt.label}</span>`;
        item.addEventListener('click', e => {
            e.stopPropagation();
            if (!opt.subMenu || opt.subMenu.length === 0) {
                opt.action(opt);
                hideMenu(true);
            }
        });

        target.appendChild(item);

        if (opt.subMenu && opt.subMenu.length) {
            const subMenu = document.createElement('ul');
            subMenu.className = 'context-sub-menu';
            item.appendChild(subMenu);
            opt.subMenu.forEach(subOpt => attachOption(subMenu, subOpt))
        }
    };

    const showMenu = (e, menuOptions) => {
        e.preventDefault();
        contextMenu.className = 'context-menu';
        contextMenu.innerHTML = '';
        menuOptions.forEach(opt => attachOption(contextMenu, opt))
        document.body.appendChild(contextMenu);

        const { innerWidth, innerHeight } = window;
        const { offsetWidth, offsetHeight } = contextMenu;
        let x = 0;
        let y = 0;

        if (e.clientX >= (innerWidth / 2)) {
            contextMenu.classList.add('left');
        }

        if (e.clientY >= (innerHeight / 2)) {
            contextMenu.classList.add('top');
        }

        if (e.clientX >= (innerWidth - offsetWidth)) {
            x = '-100%';
        }

        if (e.clientY >= (innerHeight - offsetHeight)) {
            y = '-100%';
        }

        contextMenu.style.left = e.clientX + 'px';
        contextMenu.style.top = e.clientY + 'px';
        contextMenu.style.transform = `translate(${x}, ${y})`;
        document.addEventListener('click', hideMenu);
        window.addEventListener('resize', hideOnResize);
    };

    return (el, options) => {
        el.addEventListener('contextmenu', (e) => showMenu(e, options));
    };
})();

document.querySelectorAll('button')
    .forEach(btn => {
        attachContextMenu(btn, [
            {
                //Select department rename

                label: "Yeniden Adlandır", action(o) { console.log(o) },
                "click": function (label) {

                    var re = document.querySelectorAll('button')

                    if (re.contentEditable == "true") {
                        re.contentEditable = "false";
                        re.innerHTML = "Yeniden Adlandır";
                    }
                    else {
                        re.contentEditable = "true";
                        re.innerHTML = "Yeniden Adlandır";
                        
                    }
                    
                }
            },
            {
                //Select department delete 

                label: "Departmanı Sil", action(o) { console.log(o) },

                "click": function (label)
                {
                    var de = document.getSelection('button')

                    if (button.style.display == "block") {

                        button.style.display = "none";
                    }
                }
                
            }
        ]);
    })


/* ----------------------------------------------------- */