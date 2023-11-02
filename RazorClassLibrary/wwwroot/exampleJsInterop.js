// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
  return prompt(message, 'Type anything here');
}

export function rotatePage() {
    document.body.style.setProperty("-webkit-transform", "rotate(180deg)", null);
}
