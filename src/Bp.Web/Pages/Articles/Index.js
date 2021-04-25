$(function () {
    var l = abp.localization.getResource('Bp');
    var dataTable = $('#ArticlesTable').DataTable({
        buttons: [
            'excel'
        ]
    },
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(bp.articles.article.getList),
            columnDefs: [
                {
                    title: l('Title'),
                    data: "title",
                    width: '80%'
                },
                {
                    title: l('Author'),
                    data: "author"
                }                
            ]
        })
    )
});