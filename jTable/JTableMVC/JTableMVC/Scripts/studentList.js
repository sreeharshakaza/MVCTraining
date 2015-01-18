jQuery(document).ready(function () {
    //Prepare jtable plugin
    $('#studentTable').jtable({
        title: 'The Student List',
        paging: true,
        actions: {
            listAction: '/Student/StudentList',
            deleteAction: '/Student/DeleteStudent',
            updateAction: '/Student/UpdateStudent',
            createAction: '/Student/CreateStudent'
        },
        fields: {
            StudentId: {
                key: true,
                create: false,
                edit: false,
                list: false
            },
            FirstName: {
                title: 'First Name',
                width: '15%'
            },
            LastName: {
                title: 'Last Name',
                list: true
            },
            Age: {
                title: 'Age',
                type: 'password',
                list: true
            },
            Address: {
                title: 'Address',
                width: '12%'
            }
        }
    });

    //Load person list from server
    $('#studentTable').jtable('load');
});