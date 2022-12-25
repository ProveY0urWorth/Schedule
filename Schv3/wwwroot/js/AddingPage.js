function AddModal(e)
{
    event.preventDefault();
    event.stopImmediatePropagation();

    var page;
    switch (e.id) {
        case 'AddSubjBtn':
            page = 'AddSubj';
            break;
        case 'AddGroupBtn':
            page = 'AddGroup';
            break;
        case 'AddTeacherBtn':
            page = 'AddTeacher';
            break;
        case 'AddClassroomBtn':
            page = 'AddClassroom'
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