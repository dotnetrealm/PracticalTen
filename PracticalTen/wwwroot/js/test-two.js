$(document).ready(() => {
    Array.from($(".btn")).forEach((btn) => {
        $(btn).click((e) => {
            let url = "/TestTwo";
            switch (e.target.id) {
                case "FileContentResultBtn":
                    url += "/GetFileContentResult";
                    break;
                case "ContentResultBtn":
                    url += "/GetContentResult";
                    break;
                case "EmptyResultBtn":
                    url += "/GetEmptyResult";
                    break;
                case "JavascriptResultBtn":
                    url += "/GetJavascriptResult";
                    break;
                case "JsonResultBtn":
                    url += "/GetJsonResult";
                    break;
                case "PartialViewResultBtn":
                    url += "/GetPartialViewResult";
                    break;;
                default:
                    url += "/Index";
                    break;
            }
            $.ajax({
                url: url,
                success: (res) => {
                    $("#ActionResult").html(res);
                },
                error: (err) => {
                    console.log(err);
                }
            });
        });
    })
})