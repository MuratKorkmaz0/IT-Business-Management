
// DataTables with Column Search by Text Inputs
document.addEventListener("DOMContentLoaded", function () {
	// Setup - add a text input to each footer cell
	$('#datatables-column-search-text-inputs tfoot th').each(function () {
		var title = $(this).text();
		$(this).html('<input type="text" class="form-control" placeholder="Search ' + title + '" />');
	});
	// DataTables
	var table = $('#datatables-column-search-text-inputs').DataTable();
	// Apply the search
	table.columns().every(function () {
		var that = this;
		$('input', this.footer()).on('keyup change clear', function () {
			if (that.search() !== this.value) {
				that
					.search(this.value)
					.draw();
			}
		});
	});
});
// DataTables with Column Search by Select Inputs
document.addEventListener("DOMContentLoaded", function () {
	$('#datatables-column-search-select-inputs').DataTable({
		initComplete: function () {
			this.api().columns().every(function () {
				var column = this;
				var select = $('<select class="form-control"><option value=""></option></select>')
					.appendTo($(column.footer()).empty())
					.on('change', function () {
						var val = $.fn.dataTable.util.escapeRegex(
							$(this).val()
						);
						column
							.search(val ? '^' + val + '$' : '', true, false)
							.draw();
					});
				column.data().unique().sort().each(function (d, j) {
					select.append('<option value="' + d + '">' + d + '</option>')
				});
			});
		}
	});
});


document.addEventListener("DOMContentLoaded", function () {
	$("#datatables-dashboard-projects").DataTable({
		pageLength: 6,
		lengthChange: false,
		bFilter: false,
		autoWidth: false
	});
});
