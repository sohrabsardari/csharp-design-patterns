using WidgetTheme;

var materialFactory = new MaterialFactory();
var antFactory = new AntFactory();

var contactForm = new ContactForm();

contactForm.Render(materialFactory);
contactForm.Render(antFactory);