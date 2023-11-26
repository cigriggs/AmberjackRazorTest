
var i = 0;
$("#addQualification").click(function () {
    $("#qualifictions").append(`
<div class="row g-3">
  <div class="col-md-6">
    <label for="qualiName${i}" class="form-label">Name</label>
    <input type="text" name="Grades[${i}].Name" class="form-control" id="qualiName${i}">
  </div>
  <div class="col-md-6">
    <label for="qualiGrade${i}" class="form-label">Grade</label>
    <input type="text" name="Grades[${i}].Grade" class="form-control" id="qualiGrade${i}">   
  </div>
</div>  
`);
    i++;
    if (i === 8) {
        $(this).attr('disabled', 'disabled');
    }
});