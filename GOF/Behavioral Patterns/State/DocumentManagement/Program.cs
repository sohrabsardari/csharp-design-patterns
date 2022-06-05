var document = new Document();

// document.Publish(); throws an error because you cannot publish in draft state

document.Render();

document.Publish();

//document.Render(); throws an error because you cannot render in published state