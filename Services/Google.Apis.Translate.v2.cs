//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Translate.v2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class DetectionsListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<DetectionsResource> _detections;
        
        private string _ETag;
        
        /// <summary>A detections contains detection results of several text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<DetectionsResource> Detections {
            get {
                return this._detections;
            }
            set {
                this._detections = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    /// <summary>An array of languages which we detect for the given text The most likely language list first.</summary>
    public class DetectionsResource : System.Collections.Generic.List<DetectionsResource.Entry> {
        
        public class Entry {
            
            private System.Nullable<double> _confidence;
            
            private System.Nullable<bool> _isReliable;
            
            private string _language;
            
            /// <summary>The confidence of the detection resul of this language.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
            public virtual System.Nullable<double> Confidence {
                get {
                    return this._confidence;
                }
                set {
                    this._confidence = value;
                }
            }
            
            /// <summary>A boolean to indicate is the language detection result reliable.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isReliable")]
            public virtual System.Nullable<bool> IsReliable {
                get {
                    return this._isReliable;
                }
                set {
                    this._isReliable = value;
                }
            }
            
            /// <summary>The language we detect</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language {
                get {
                    return this._language;
                }
                set {
                    this._language = value;
                }
            }
        }
    }
    
    public class LanguagesListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<LanguagesResource> _languages;
        
        private string _ETag;
        
        /// <summary>List of source/target languages supported by the translation API. If target parameter is unspecified, the list is sorted by the ASCII code point order of the language code. If target parameter is specified, the list is sorted by the collation order of the language name in the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<LanguagesResource> Languages {
            get {
                return this._languages;
            }
            set {
                this._languages = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class LanguagesResource {
        
        private string _language;
        
        private string _name;
        
        /// <summary>The language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language {
            get {
                return this._language;
            }
            set {
                this._language = value;
            }
        }
        
        /// <summary>The localized name of the language if target parameter is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
    }
    
    public class TranslationsListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<TranslationsResource> _translations;
        
        private string _ETag;
        
        /// <summary>Translations contains list of translation results of given text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual System.Collections.Generic.IList<TranslationsResource> Translations {
            get {
                return this._translations;
            }
            set {
                this._translations = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class TranslationsResource {
        
        private string _detectedSourceLanguage;
        
        private string _translatedText;
        
        /// <summary>Detected source language if source parameter is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSourceLanguage")]
        public virtual string DetectedSourceLanguage {
            get {
                return this._detectedSourceLanguage;
            }
            set {
                this._detectedSourceLanguage = value;
            }
        }
        
        /// <summary>The translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText {
            get {
                return this._translatedText;
            }
            set {
                this._translatedText = value;
            }
        }
    }
}
namespace Google.Apis.Translate.v2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class TranslateService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"discoveryVersion\":\"v1\",\"id\":\"translate:v2\",\"" +
            "name\":\"translate\",\"version\":\"v2\",\"revision\":\"20120112\",\"title\":\"Translate API\",\"" +
            "description\":\"Lets you translate text from one language to another\",\"icons\":{\"x1" +
            "6\":\"http://www.google.com/images/icons/product/translate-16.png\",\"x32\":\"http://w" +
            "ww.google.com/images/icons/product/translate-32.png\"},\"documentationLink\":\"http:" +
            "//code.google.com/apis/language/translate/v2/using_rest.html\",\"protocol\":\"rest\"," +
            "\"baseUrl\":\"https://www.googleapis.com/language/translate/\",\"basePath\":\"/language" +
            "/translate/\",\"rootUrl\":\"https://www.googleapis.com/\",\"servicePath\":\"language/tra" +
            "nslate/\",\"batchPath\":\"batch\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":" +
            "\"Data format for the response.\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDescriptio" +
            "ns\":[\"Responses with Content-Type of application/json\"],\"location\":\"query\"},\"fie" +
            "lds\":{\"type\":\"string\",\"description\":\"Selector specifying which fields to include" +
            " in a partial response.\",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"description" +
            "\":\"API key. Your API key identifies your project and provides you with API acces" +
            "s, quota, and reports. Required unless you provide an OAuth 2.0 token.\",\"locatio" +
            "n\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token for th" +
            "e current user.\",\"location\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"descriptio" +
            "n\":\"Returns response with indentations and line breaks.\",\"default\":\"true\",\"locat" +
            "ion\":\"query\"},\"quotaUser\":{\"type\":\"string\",\"description\":\"Available to use for q" +
            "uota purposes for server-side applications. Can be any arbitrary string assigned" +
            " to a user, but should not exceed 40 characters. Overrides userIp if both are pr" +
            "ovided.\",\"location\":\"query\"},\"userIp\":{\"type\":\"string\",\"description\":\"IP address" +
            " of the site where the request originates. Use this if you want to enforce per-u" +
            "ser limits.\",\"location\":\"query\"}},\"features\":[\"dataWrapper\"],\"schemas\":{\"Detecti" +
            "onsListResponse\":{\"id\":\"DetectionsListResponse\",\"type\":\"object\",\"properties\":{\"d" +
            "etections\":{\"type\":\"array\",\"description\":\"A detections contains detection result" +
            "s of several text\",\"items\":{\"$ref\":\"DetectionsResource\"}}}},\"DetectionsResource\"" +
            ":{\"id\":\"DetectionsResource\",\"type\":\"array\",\"description\":\"An array of languages " +
            "which we detect for the given text The most likely language list first.\",\"items\"" +
            ":{\"type\":\"object\",\"properties\":{\"confidence\":{\"type\":\"number\",\"description\":\"The" +
            " confidence of the detection resul of this language.\",\"format\":\"float\"},\"isRelia" +
            "ble\":{\"type\":\"boolean\",\"description\":\"A boolean to indicate is the language dete" +
            "ction result reliable.\"},\"language\":{\"type\":\"string\",\"description\":\"The language" +
            " we detect\"}}}},\"LanguagesListResponse\":{\"id\":\"LanguagesListResponse\",\"type\":\"ob" +
            "ject\",\"properties\":{\"languages\":{\"type\":\"array\",\"description\":\"List of source/ta" +
            "rget languages supported by the translation API. If target parameter is unspecif" +
            "ied, the list is sorted by the ASCII code point order of the language code. If t" +
            "arget parameter is specified, the list is sorted by the collation order of the l" +
            "anguage name in the target language.\",\"items\":{\"$ref\":\"LanguagesResource\"}}}},\"L" +
            "anguagesResource\":{\"id\":\"LanguagesResource\",\"type\":\"object\",\"properties\":{\"langu" +
            "age\":{\"type\":\"string\",\"description\":\"The language code.\"},\"name\":{\"type\":\"string" +
            "\",\"description\":\"The localized name of the language if target parameter is given" +
            ".\"}}},\"TranslationsListResponse\":{\"id\":\"TranslationsListResponse\",\"type\":\"object" +
            "\",\"properties\":{\"translations\":{\"type\":\"array\",\"description\":\"Translations conta" +
            "ins list of translation results of given text\",\"items\":{\"$ref\":\"TranslationsReso" +
            "urce\"}}}},\"TranslationsResource\":{\"id\":\"TranslationsResource\",\"type\":\"object\",\"p" +
            "roperties\":{\"detectedSourceLanguage\":{\"type\":\"string\",\"description\":\"Detected so" +
            "urce language if source parameter is unspecified.\"},\"translatedText\":{\"type\":\"st" +
            "ring\",\"description\":\"The translation.\"}}}},\"resources\":{\"detections\":{\"methods\":" +
            "{\"list\":{\"id\":\"language.detections.list\",\"path\":\"v2/detect\",\"httpMethod\":\"GET\",\"" +
            "description\":\"Detect the language of text.\",\"parameters\":{\"q\":{\"type\":\"string\",\"" +
            "description\":\"The text to detect\",\"required\":true,\"repeated\":true,\"location\":\"qu" +
            "ery\"}},\"parameterOrder\":[\"q\"],\"response\":{\"$ref\":\"DetectionsListResponse\"}}}},\"l" +
            "anguages\":{\"methods\":{\"list\":{\"id\":\"language.languages.list\",\"path\":\"v2/language" +
            "s\",\"httpMethod\":\"GET\",\"description\":\"List the source/target languages supported " +
            "by the API\",\"parameters\":{\"target\":{\"type\":\"string\",\"description\":\"the language " +
            "and collation in which the localized results should be returned\",\"location\":\"que" +
            "ry\"}},\"response\":{\"$ref\":\"LanguagesListResponse\"}}}},\"translations\":{\"methods\":{" +
            "\"list\":{\"id\":\"language.translations.list\",\"path\":\"v2\",\"httpMethod\":\"GET\",\"descri" +
            "ption\":\"Returns text translations from one language to another.\",\"parameters\":{\"" +
            "cid\":{\"type\":\"string\",\"description\":\"The customization id for translate\",\"repeat" +
            "ed\":true,\"location\":\"query\"},\"format\":{\"type\":\"string\",\"description\":\"The format" +
            " of the text\",\"enum\":[\"html\",\"text\"],\"enumDescriptions\":[\"Specifies the input is" +
            " in HTML\",\"Specifies the input is in plain textual format\"],\"location\":\"query\"}," +
            "\"q\":{\"type\":\"string\",\"description\":\"The text to translate\",\"required\":true,\"repe" +
            "ated\":true,\"location\":\"query\"},\"source\":{\"type\":\"string\",\"description\":\"The sour" +
            "ce language of the text\",\"location\":\"query\"},\"target\":{\"type\":\"string\",\"descript" +
            "ion\":\"The target language into which the text should be translated\",\"required\":t" +
            "rue,\"location\":\"query\"}},\"parameterOrder\":[\"q\",\"target\"],\"response\":{\"$ref\":\"Tra" +
            "nslationsListResponse\"}}}}}}";
        
        public const string Version = "v2";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected TranslateService(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._detections = new DetectionsResource(this, _authenticator);
            this._languages = new LanguagesResource(this, _authenticator);
            this._translations = new TranslationsResource(this, _authenticator);
        }
        
        public TranslateService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public TranslateService(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(TranslateService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/language/translate/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "translate";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/language/translate/";
            }
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this._service.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(_authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            _service.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return _service.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return _service.DeserializeResponse<T>(response);
        }
    }
    
    public class DetectionsResource {
        
        private TranslateService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "detections";
        
        public DetectionsResource(TranslateService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Detect the language of text.</summary>
        /// <param name="q">Required - The text to detect</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q) {
            return new ListRequest(service, q);
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Translate.v2.Data.DetectionsListResponse> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private Google.Apis.Util.Repeatable<string> _q;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> q) : 
                    base(service) {
                this._q = q;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>The text to detect</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Q {
                get {
                    return this._q;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "detections";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public class LanguagesResource {
        
        private TranslateService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "languages";
        
        public LanguagesResource(TranslateService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>List the source/target languages supported by the API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Translate.v2.Data.LanguagesListResponse> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _target;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>the language and collation in which the localized results should be returned</summary>
            [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Target {
                get {
                    return this._target;
                }
                set {
                    this._target = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "languages";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public class TranslationsResource {
        
        private TranslateService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "translations";
        
        public TranslationsResource(TranslateService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">Required - The text to translate</param>
        /// <param name="target">Required - The target language into which the text should be translated</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q, string target) {
            return new ListRequest(service, q, target);
        }
        
        /// <summary>The format of the text</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Format {
            
            /// <summary>Specifies the input is in HTML</summary>
            [Google.Apis.Util.StringValueAttribute("html")]
            Html,
            
            /// <summary>Specifies the input is in plain textual format</summary>
            [Google.Apis.Util.StringValueAttribute("text")]
            Text,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Translate.v2.Data.TranslationsListResponse> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private Google.Apis.Util.Repeatable<string> _cid;
            
            private System.Nullable<Format> _format;
            
            private Google.Apis.Util.Repeatable<string> _q;
            
            private string _source;
            
            private string _target;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Util.Repeatable<string> q, string target) : 
                    base(service) {
                this._q = q;
                this._target = target;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>The customization id for translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("cid", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Cid {
                get {
                    return this._cid;
                }
                set {
                    this._cid = value;
                }
            }
            
            /// <summary>The format of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Format> Format {
                get {
                    return this._format;
                }
                set {
                    this._format = value;
                }
            }
            
            /// <summary>The text to translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Q {
                get {
                    return this._q;
                }
            }
            
            /// <summary>The source language of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source {
                get {
                    return this._source;
                }
                set {
                    this._source = value;
                }
            }
            
            /// <summary>The target language into which the text should be translated</summary>
            [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Target {
                get {
                    return this._target;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "translations";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class TranslateService {
        
        private const string Resource = "";
        
        private DetectionsResource _detections;
        
        private LanguagesResource _languages;
        
        private TranslationsResource _translations;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual DetectionsResource Detections {
            get {
                return this._detections;
            }
        }
        
        public virtual LanguagesResource Languages {
            get {
                return this._languages;
            }
        }
        
        public virtual TranslationsResource Translations {
            get {
                return this._translations;
            }
        }
    }
}
