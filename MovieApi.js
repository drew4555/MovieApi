
$("button").click(function(){
 $.get("https://localhost:44312/api/movies", function(data){
  $.each(data, function(key, value){
    $("#myTable").append(`<tr><td>${value.Title} </td> <td> ${value.Genre} </td> <td> ${value.DirectorName} </td</tr>`)
  });
});
});