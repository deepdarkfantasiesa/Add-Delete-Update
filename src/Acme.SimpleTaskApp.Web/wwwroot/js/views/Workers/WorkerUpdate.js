(function ($) {
    $(function () {

        var _$formUpdate = $('#WorkerUpdateForm');

        _$formUpdate.find('input:first').focus();

        _$formUpdate.validate();
        console.log("worker. update");

        $(".WorkerDelBtn").click(function (e) {
            console.log("del button " + this.id)

            var input = {};
            input.id = this.id;
            abp.services.app.worker.delete(input)
                .done(function () {
                    console.log("delete done");
                    location.href = '/Workers';
                });

        } )


        $("#WorkerUpdateSubmit").click(function (e) {

                console.log("update prevent");

                e.preventDefault();

                console.log("onclick");

                if (!_$formUpdate.valid()) {
                    return;
                }


                var input = _$formUpdate.serializeFormToObject(); 
               
                abp.services.app.worker.update(input)
                    .done(function () {
                        console.log("update done");
                        location.href = '/Workers';
                    });
            });
    });
})(jQuery);