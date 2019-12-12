(function ($) {
    $(function () {

        var _$formUpdate = $('#CertificationUpdateForm');

        _$formUpdate.find('input:first').focus();
        
        _$formUpdate.validate();
        console.log("worker. update");
        
        $(".CertDelBtn").click(function (e) {
            console.log("del button " + this.id)

            var input = {};
            input.id = this.id;
            abp.services.app.certificate.delete(input)
                .done(function () {
                    //console.log("delete done");
                    location.href = '/Certs';
                });

        })
        

        $("#CertificationUpdateSubmit").click(function (e) {//更新代码

            console.log("update prevent");

            e.preventDefault();

            console.log("onclick");

            if (!_$formUpdate.valid()) {
                return;
            }


            var input = _$formUpdate.serializeFormToObject();

            abp.services.app.certificate.update(input)
                .done(function () {
                    console.log("update done");
                    location.href = '/Certs';
                });
        });
    });
})(jQuery);