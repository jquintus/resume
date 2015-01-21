var fs = require("fs");
var Handlebars = require("handlebars");

function getMonth(date) {
  switch (date.substr(5,2)) {
    case '01': return "January";
    case '02': return "February";
    case '03': return "March";
    case '04': return "April";
    case '05': return "May";
    case '06': return "June";
    case '07': return "July";
    case '08': return "August";
    case '09': return "September";
    case '10': return "October";
    case '11': return "November";
    case '12': return "December";
  }
}

function createReadableDates(w){
  if (w.startDate){
    var startDateYear = (w.startDate || "").substr(0,4);
    var startDateMonth = getMonth(w.startDate || "");

    w.startDateReadable = startDateMonth + " " + startDateYear;
  }

  if (w.endDate){
    var endDateYear = (w.endDate || "").substr(0,4);
    var endDateMonth = getMonth(w.endDate || "");
    w.endDateReadable = endDateMonth + " " + endDateYear;
  }
  else
  {
    w.endDateReadable = "Present";
  }
}

function render(resume) {

  if (resume.work){
    resume.work.forEach(function(w) {
      createReadableDates(w);
    });
  }

  if (resume.education){
    resume.education.forEach(function(w) {
      createReadableDates(w);
    });
  }

  if (resume.volunteer){
    resume.volunteer.forEach(function(w) {
      createReadableDates(w);
    });
  }

	var css = fs.readFileSync(__dirname + "/style.css", "utf-8");
	var template = fs.readFileSync(__dirname + "/resume.template", "utf-8");

	return Handlebars.compile(template)({
		css: css,
		resume: resume
	});
}

module.exports = {
	render: render
};
