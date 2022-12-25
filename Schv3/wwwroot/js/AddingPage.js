function AddModal(e)
{
    event.preventDefault();
    event.stopImmediatePropagation();

    var page;
    switch (e.id) {
        case 'AddSubjBtn':
            page = 'AddSubj';
            $('.modal-title').html("Добавить предмет");
            break;
        case 'AddGroupBtn':
            page = 'AddGroup';
            $('.modal-title').html("Добавить группу");
            break;
        case 'AddTeacherBtn':
            page = 'AddTeacher';
            $('.modal-title').html("Добавить преподавателя");
            break;
        case 'AddClassroomBtn':
            page = 'AddClassroom'
            $('.modal-title').html("Добавить аудиторию");
            break;
        default:
            break;
    }

    $.ajax({
        url: page,
        type: 'GET',
        success: function (data) {
            $('#AddFormModalbody').html(data);
            $('#AddFormModal').modal('show');
        },
        error: function () {
            alert("There is some problem in the service!")
        }
    });
}

function AddToDB() {
}

function SchedToDB() {

}

function ModalClose() {
    $('#AddFormModal').modal('hide');
}