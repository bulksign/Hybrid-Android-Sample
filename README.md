# Hybrid-UWP-Sample
Sample for integrating the Bulksign signing experience in a hybrid Android application (using Xamarin). The integration can be done in the following ways :

- using the generic "bulksign://" protocol and the email link : the application needs to register the protocol and the sample app will redirect accordingly and open the signing document.

- if you use the Bulksign API to send a document from the Android app, set SigningSettings.Argument  = documentAccessCode and redirect to AccessCodeEnterUrl to directly open the document for signing.

