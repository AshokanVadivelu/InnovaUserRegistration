var regex = /^([\w-.]+@([\w-]+\.)+[\w-]{2,4})?$/;
$(function () {
    $(document).ajaxStart(function () {
        $('.container body-content').fadeIn(200, 1)
        ShowLoader();
        console.log("ajax start event fired");
    });

    $(document).ajaxComplete(function (event, request, settings) {
        ShowLoader();
        $('.container body-content').fadeOut(200);
        console.log("ajax complete event fired");
    });

    $(document).ajaxError(function (event, jqxhr, settings, thrownError) {        
        HideLoader();
        console.log(thrownError);
        console.log("ajax error event fired");
    });

    function ShowLoader() {
        setTimeout(function () {
            //document.body.removeChild(modal);            
            $('loading').show();
        }, 2000); //Delay just used for example and must be set to 0.
    }

    function HideLoader() {
         setTimeout(function () {
             //document.body.removeChild(modal);
             $('loading').hide();
            }, 2000); //Delay just used for example and must be set to 0.
    }

    function IsValid(email) {
        return regex.test(email);            
    }
});