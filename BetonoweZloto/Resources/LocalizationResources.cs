namespace BetonoweZloto.Resources;

public static class LocalizationResources
{
    public static class Navigation
    {
        public static readonly Dictionary<string, string> Home = new() { { "pl", "Strona g³ówna" }, { "en", "Home" } };
        public static readonly Dictionary<string, string> Search = new() { { "pl", "Wyszukiwarka" }, { "en", "Search" } };
        public static readonly Dictionary<string, string> About = new() { { "pl", "O nas" }, { "en", "About Us" } };
        public static readonly Dictionary<string, string> Blog = new() { { "pl", "Porady" }, { "en", "Blog" } };
        public static readonly Dictionary<string, string> Contact = new() { { "pl", "Kontakt" }, { "en", "Contact" } };
    }

    public static class HomePage
    {
        public static readonly Dictionary<string, string> Title = new() { { "pl", "ZnajdŸ swoj¹" }, { "en", "Find your" } };
        public static readonly Dictionary<string, string> TitleHighlight = new() { { "pl", "nieruchomoœæ" }, { "en", "property" } };
        public static readonly Dictionary<string, string> Subtitle = new() { { "pl", "Profesjonalne doradztwo i kompleksowa obs³uga" }, { "en", "Professional consulting and comprehensive service" } };
        public static readonly Dictionary<string, string> ViewOffers = new() { { "pl", "Zobacz oferty" }, { "en", "View Offers" } };
        public static readonly Dictionary<string, string> ContactUs = new() { { "pl", "Skontaktuj siê" }, { "en", "Contact Us" } };
        public static readonly Dictionary<string, string> AboutHeading = new() { { "pl", "Twój Partner w Œwiecie Nieruchomoœci" }, { "en", "Your Partner in the Real Estate World" } };
        public static readonly Dictionary<string, string> AboutText = new() { { "pl", "BetonoweZloto.pl to doœwiadczone biuro obrotu nieruchomoœciami, które od lat z sukcesem pomaga klientom znaleŸæ wymarzone mieszkania, domy i lokale komercyjne." }, { "en", "BetonoweZloto.pl is an experienced real estate agency that has been successfully helping clients find their dream apartments, houses and commercial premises for years." } };
        public static readonly Dictionary<string, string> ExperienceTitle = new() { { "pl", "Wieloletnie Doœwiadczenie" }, { "en", "Years of Experience" } };
        public static readonly Dictionary<string, string> ExperienceText = new() { { "pl", "Ponad 15 lat na rynku nieruchomoœci. Setki zadowolonych klientów i pomyœlnie zakoñczonych transakcji." }, { "en", "Over 15 years in the real estate market. Hundreds of satisfied clients and successfully completed transactions." } };
        public static readonly Dictionary<string, string> TeamTitle = new() { { "pl", "Profesjonalny Zespó³" }, { "en", "Professional Team" } };
        public static readonly Dictionary<string, string> TeamText = new() { { "pl", "Zespó³ ekspertów z pasj¹ i zaanga¿owaniem, którzy dopasuj¹ ofertê do Twoich potrzeb i bud¿etu." }, { "en", "A team of experts with passion and commitment who will match the offer to your needs and budget." } };
        public static readonly Dictionary<string, string> PortfolioTitle = new() { { "pl", "Szeroka Oferta" }, { "en", "Wide Range" } };
        public static readonly Dictionary<string, string> PortfolioText = new() { { "pl", "Mieszkania, domy, lokale u¿ytkowe w najlepszych lokalizacjach. Znajdziemy idealn¹ nieruchomoœæ dla Ciebie." }, { "en", "Apartments, houses, commercial premises in the best locations. We will find the perfect property for you." } };
        public static readonly Dictionary<string, string> FeaturedHeading = new() { { "pl", "Wyró¿nione Oferty" }, { "en", "Featured Offers" } };
        public static readonly Dictionary<string, string> FeaturedSubheading = new() { { "pl", "SprawdŸ nasze najnowsze i najbardziej atrakcyjne nieruchomoœci" }, { "en", "Check out our newest and most attractive properties" } };
        public static readonly Dictionary<string, string> ViewAllOffers = new() { { "pl", "Zobacz wszystkie oferty" }, { "en", "View All Offers" } };
        public static readonly Dictionary<string, string> CtaHeading = new() { { "pl", "Szukasz Swojego Miejsca na Ziemi?" }, { "en", "Looking for Your Dream Property?" } };
        public static readonly Dictionary<string, string> CtaText = new() { { "pl", "Skontaktuj siê z nami ju¿ dziœ, a nasi eksperci pomog¹ Ci znaleŸæ idealn¹ nieruchomoœæ" }, { "en", "Contact us today and our experts will help you find the perfect property" } };
    }

    public static class SearchPage
    {
        public static readonly Dictionary<string, string> Title = new() { { "pl", "ZnajdŸ Nieruchomoœæ" }, { "en", "Find Property" } };
        public static readonly Dictionary<string, string> Subtitle = new() { { "pl", "Przeszukaj nasz¹ bazê, aby znaleŸæ idealne miejsce dla siebie." }, { "en", "Search our database to find the perfect place for you." } };
        public static readonly Dictionary<string, string> Filters = new() { { "pl", "Filtry" }, { "en", "Filters" } };
        public static readonly Dictionary<string, string> Location = new() { { "pl", "Lokalizacja lub s³owo kluczowe" }, { "en", "Location or keyword" } };
        public static readonly Dictionary<string, string> LocationPlaceholder = new() { { "pl", "np. Warszawa..." }, { "en", "e.g. Warsaw..." } };
        public static readonly Dictionary<string, string> PropertyType = new() { { "pl", "Typ nieruchomoœci" }, { "en", "Property type" } };
        public static readonly Dictionary<string, string> AllTypes = new() { { "pl", "Wszystkie" }, { "en", "All Types" } };
        public static readonly Dictionary<string, string> Apartment = new() { { "pl", "Mieszkanie" }, { "en", "Apartment" } };
        public static readonly Dictionary<string, string> House = new() { { "pl", "Dom" }, { "en", "House" } };
        public static readonly Dictionary<string, string> Commercial = new() { { "pl", "Lokal u¿ytkowy" }, { "en", "Commercial" } };
        public static readonly Dictionary<string, string> MaxPrice = new() { { "pl", "Cena maksymalna (z³)" }, { "en", "Maximum price (PLN)" } };
        public static readonly Dictionary<string, string> NoLimit = new() { { "pl", "Bez limitu" }, { "en", "No limit" } };
        public static readonly Dictionary<string, string> Rooms = new() { { "pl", "Liczba pokoi (dok³adnie)" }, { "en", "Number of rooms (exact)" } };
        public static readonly Dictionary<string, string> FilterButton = new() { { "pl", "Filtruj Wyniki" }, { "en", "Filter Results" } };
        public static readonly Dictionary<string, string> ClearFilters = new() { { "pl", "Wyczyœæ wszystkie filtry" }, { "en", "Clear all filters" } };
        public static readonly Dictionary<string, string> ResultsCount = new() { { "pl", "Znaleziono ofert:" }, { "en", "Properties found:" } };
        public static readonly Dictionary<string, string> ViewDetails = new() { { "pl", "Zobacz szczegó³y" }, { "en", "View Details" } };
        public static readonly Dictionary<string, string> NoResults = new() { { "pl", "Brak wyników wyszukiwania" }, { "en", "No search results" } };
        public static readonly Dictionary<string, string> NoResultsText = new() { { "pl", "Nie znaleŸliœmy ofert spe³niaj¹cych Twoje kryteria. Spróbuj zmieniæ parametry wyszukiwania lub wyczyœæ filtry." }, { "en", "We couldn't find any properties matching your criteria. Try changing the search parameters or clear the filters." } };
    }

    public static class DetailsPage
    {
        public static readonly Dictionary<string, string> NotFound = new() { { "pl", "Nie znaleziono oferty" }, { "en", "Property not found" } };
        public static readonly Dictionary<string, string> NotFoundText = new() { { "pl", "Oferta o podanym identyfikatorze nie istnieje lub zosta³a usuniêta." }, { "en", "The property with the given ID does not exist or has been removed." } };
        public static readonly Dictionary<string, string> BackToOffers = new() { { "pl", "Powrót do ofert" }, { "en", "Back to Offers" } };
        public static readonly Dictionary<string, string> KeyInfo = new() { { "pl", "Kluczowe Informacje" }, { "en", "Key Information" } };
        public static readonly Dictionary<string, string> Area = new() { { "pl", "powierzchnia" }, { "en", "area" } };
        public static readonly Dictionary<string, string> Rooms = new() { { "pl", "pokoje" }, { "en", "rooms" } };
        public static readonly Dictionary<string, string> YearBuilt = new() { { "pl", "rok budowy" }, { "en", "year built" } };
        public static readonly Dictionary<string, string> Description = new() { { "pl", "Opis Nieruchomoœci" }, { "en", "Property Description" } };
        public static readonly Dictionary<string, string> Features = new() { { "pl", "Dodatkowe Udogodnienia" }, { "en", "Additional Features" } };
        public static readonly Dictionary<string, string> ContactHeading = new() { { "pl", "Skontaktuj siê z nami" }, { "en", "Contact Us" } };
        public static readonly Dictionary<string, string> ContactText = new() { { "pl", "Nasi eksperci s¹ gotowi odpowiedzieæ na wszystkie pytania dotycz¹ce tej nieruchomoœci." }, { "en", "Our experts are ready to answer all your questions about this property." } };
        public static readonly Dictionary<string, string> Call = new() { { "pl", "Zadzwoñ" }, { "en", "Call" } };
        public static readonly Dictionary<string, string> Email = new() { { "pl", "Wyœlij Email" }, { "en", "Send Email" } };
        public static readonly Dictionary<string, string> Hours = new() { { "pl", "Godziny pracy:" }, { "en", "Working hours:" } };
        public static readonly Dictionary<string, string> HoursWeekday = new() { { "pl", "Pn-Pt: 9:00-18:00" }, { "en", "Mon-Fri: 9:00-18:00" } };
        public static readonly Dictionary<string, string> HoursSaturday = new() { { "pl", "Sob: 10:00-14:00" }, { "en", "Sat: 10:00-14:00" } };
        public static readonly Dictionary<string, string> Info = new() { { "pl", "Informacje" }, { "en", "Information" } };
        public static readonly Dictionary<string, string> PropertyId = new() { { "pl", "ID oferty:" }, { "en", "Property ID:" } };
        public static readonly Dictionary<string, string> Status = new() { { "pl", "Status:" }, { "en", "Status:" } };
        public static readonly Dictionary<string, string> Available = new() { { "pl", "Dostêpne" }, { "en", "Available" } };
        public static readonly Dictionary<string, string> AddedDate = new() { { "pl", "Data dodania:" }, { "en", "Date added:" } };
        public static readonly Dictionary<string, string> Views = new() { { "pl", "Ods³on:" }, { "en", "Views:" } };
    }

    public static class ContactPage
    {
        public static readonly Dictionary<string, string> Title = new() { { "pl", "Skontaktuj Siê z Nami" }, { "en", "Contact Us" } };
        public static readonly Dictionary<string, string> Subtitle = new() { { "pl", "Jesteœmy tutaj, aby pomóc Ci znaleŸæ wymarzon¹ nieruchomoœæ. Napisz lub zadzwoñ!" }, { "en", "We are here to help you find your dream property. Write or call!" } };
        public static readonly Dictionary<string, string> Phone = new() { { "pl", "Telefon" }, { "en", "Phone" } };
        public static readonly Dictionary<string, string> PhoneHours = new() { { "pl", "Pon-Pt: 9:00-18:00\nSob: 10:00-14:00" }, { "en", "Mon-Fri: 9:00-18:00\nSat: 10:00-14:00" } };
        public static readonly Dictionary<string, string> Email = new() { { "pl", "E-mail" }, { "en", "E-mail" } };
        public static readonly Dictionary<string, string> EmailResponse = new() { { "pl", "Odpowiadamy w ci¹gu 24h" }, { "en", "We respond within 24h" } };
        public static readonly Dictionary<string, string> Address = new() { { "pl", "Adres" }, { "en", "Address" } };
        public static readonly Dictionary<string, string> AddressLocation = new() { { "pl", "Centrum miasta" }, { "en", "City center" } };
        public static readonly Dictionary<string, string> NIP = new() { { "pl", "NIP" }, { "en", "TAX ID" } };
        public static readonly Dictionary<string, string> NIPDescription = new() { { "pl", "Numer identyfikacji\npodatkowej" }, { "en", "Tax identification\nnumber" } };
        public static readonly Dictionary<string, string> FormTitle = new() { { "pl", "Wyœlij Wiadomoœæ" }, { "en", "Send Message" } };
        public static readonly Dictionary<string, string> FormName = new() { { "pl", "Imiê i nazwisko" }, { "en", "Full name" } };
        public static readonly Dictionary<string, string> FormNamePlaceholder = new() { { "pl", "Jan Kowalski" }, { "en", "John Smith" } };
        public static readonly Dictionary<string, string> FormEmail = new() { { "pl", "E-mail" }, { "en", "E-mail" } };
        public static readonly Dictionary<string, string> FormEmailPlaceholder = new() { { "pl", "jan.kowalski@example.com" }, { "en", "john.smith@example.com" } };
        public static readonly Dictionary<string, string> FormPhone = new() { { "pl", "Telefon" }, { "en", "Phone" } };
        public static readonly Dictionary<string, string> FormPhonePlaceholder = new() { { "pl", "+48 123 456 789" }, { "en", "+48 123 456 789" } };
        public static readonly Dictionary<string, string> FormSubject = new() { { "pl", "Temat" }, { "en", "Subject" } };
        public static readonly Dictionary<string, string> FormSubjectSelect = new() { { "pl", "Wybierz temat" }, { "en", "Select subject" } };
        public static readonly Dictionary<string, string> FormSubjectBuy = new() { { "pl", "Chcê kupiæ nieruchomoœæ" }, { "en", "I want to buy a property" } };
        public static readonly Dictionary<string, string> FormSubjectSell = new() { { "pl", "Chcê sprzedaæ nieruchomoœæ" }, { "en", "I want to sell a property" } };
        public static readonly Dictionary<string, string> FormSubjectRent = new() { { "pl", "Szukam wynajmu" }, { "en", "Looking for rent" } };
        public static readonly Dictionary<string, string> FormSubjectValuation = new() { { "pl", "Wycena nieruchomoœci" }, { "en", "Property valuation" } };
        public static readonly Dictionary<string, string> FormSubjectOther = new() { { "pl", "Inne pytanie" }, { "en", "Other question" } };
        public static readonly Dictionary<string, string> FormMessage = new() { { "pl", "Wiadomoœæ" }, { "en", "Message" } };
        public static readonly Dictionary<string, string> FormMessagePlaceholder = new() { { "pl", "Opisz swoje pytanie lub potrzeby" }, { "en", "Describe your question or needs" } };
        public static readonly Dictionary<string, string> FormConsent = new() { { "pl", "Wyra¿am zgodê na przetwarzanie moich danych osobowych zgodnie z polityk¹ prywatnoœci" }, { "en", "I consent to the processing of my personal data in accordance with the privacy policy" } };
        public static readonly Dictionary<string, string> FormSubmit = new() { { "pl", "Wyœlij wiadomoœæ" }, { "en", "Send message" } };
        public static readonly Dictionary<string, string> FormSending = new() { { "pl", "Wysy³anie..." }, { "en", "Sending..." } };
        public static readonly Dictionary<string, string> FormSuccess = new() { { "pl", "Dziêkujemy za wiadomoœæ! Skontaktujemy siê z Tob¹ w ci¹gu 24 godzin." }, { "en", "Thank you for your message! We will contact you within 24 hours." } };
        public static readonly Dictionary<string, string> FormError = new() { { "pl", "Proszê poprawiæ b³êdy w formularzu" }, { "en", "Please correct the errors in the form" } };
        public static readonly Dictionary<string, string> FormRequired = new() { { "pl", "Pole wymagane" }, { "en", "Required field" } };
        public static readonly Dictionary<string, string> FormInvalidEmail = new() { { "pl", "Nieprawid³owy adres email" }, { "en", "Invalid email address" } };
        public static readonly Dictionary<string, string> FormMessageTooShort = new() { { "pl", "Wiadomoœæ jest zbyt krótka (min. 10 znaków)" }, { "en", "Message is too short (min. 10 characters)" } };
        public static readonly Dictionary<string, string> FormConsentRequired = new() { { "pl", "Musisz wyraziæ zgodê na przetwarzanie danych osobowych" }, { "en", "You must consent to the processing of personal data" } };
        public static readonly Dictionary<string, string> SocialTitle = new() { { "pl", "Obserwuj Nas w Social Media" }, { "en", "Follow Us on Social Media" } };
        public static readonly Dictionary<string, string> SocialSubtitle = new() { { "pl", "B¹dŸ na bie¿¹co z nowymi ofertami, poradami i aktualnoœciami" }, { "en", "Stay up to date with new offers, tips and news" } };
    }

    public static class AboutPage
    {
        public static readonly Dictionary<string, string> Title = new() { { "pl", "Poznaj Nasz Zespó³" }, { "en", "Meet Our Team" } };
        public static readonly Dictionary<string, string> Subtitle = new() { { "pl", "Pasja, doœwiadczenie i zaanga¿owanie w s³u¿bie Twoim marzeniom o idealnym domu" }, { "en", "Passion, experience and commitment to serve your dreams of the perfect home" } };
        public static readonly Dictionary<string, string> HistoryTitle = new() { { "pl", "Nasza Historia" }, { "en", "Our Story" } };
        public static readonly Dictionary<string, string> HistoryText1 = new() { { "pl", "BetonoweZloto.pl powsta³o w 2009 roku z prostej wizji: pomóc ludziom znaleŸæ wymarzone miejsce do ¿ycia. Od tamtej pory przeszliœmy d³ug¹ drogê, staj¹c siê jednym z najbardziej zaufanych biur nieruchomoœci w Polsce." }, { "en", "BetonoweZloto.pl was founded in 2009 with a simple vision: to help people find their dream place to live. Since then, we have come a long way, becoming one of the most trusted real estate agencies in Poland." } };
        public static readonly Dictionary<string, string> HistoryText2 = new() { { "pl", "Przez ponad 15 lat dzia³alnoœci pomogliœmy setkom rodzin znaleŸæ ich wymarzone miejsce, które mog¹ nazwaæ domem. Nasze doœwiadczenie obejmuje sprzeda¿ mieszkañ, domów oraz lokali u¿ytkowych w najwiêkszych miastach Polski." }, { "en", "For over 15 years, we have helped hundreds of families find their dream place they can call home. Our experience includes the sale of apartments, houses and commercial premises in the largest cities in Poland." } };
        public static readonly Dictionary<string, string> HistoryText3 = new() { { "pl", "Nasz sukces opiera siê na trzech filarach: profesjonalizmie, uczciwoœci i indywidualnym podejœciu do ka¿dego klienta. Wierzymy, ¿e kupno lub sprzeda¿ nieruchomoœci to jedna z najwa¿niejszych decyzji w ¿yciu, dlatego traktujemy ka¿d¹ transakcjê z najwy¿sz¹ starannoœci¹." }, { "en", "Our success is based on three pillars: professionalism, honesty and individual approach to each client. We believe that buying or selling real estate is one of the most important decisions in life, so we treat each transaction with the utmost care." } };
        public static readonly Dictionary<string, string> ExperienceYears = new() { { "pl", "lat doœwiadczenia" }, { "en", "years of experience" } };
        public static readonly Dictionary<string, string> StatsClients = new() { { "pl", "Zadowolonych klientów" }, { "en", "Satisfied clients" } };
        public static readonly Dictionary<string, string> StatsProperties = new() { { "pl", "Sprzedanych nieruchomoœci" }, { "en", "Properties sold" } };
        public static readonly Dictionary<string, string> StatsYears = new() { { "pl", "Lat na rynku" }, { "en", "Years on the market" } };
        public static readonly Dictionary<string, string> StatsRecommendations = new() { { "pl", "Rekomendacji" }, { "en", "Recommendations" } };
        public static readonly Dictionary<string, string> ValuesTitle = new() { { "pl", "Nasze Wartoœci" }, { "en", "Our Values" } };
        public static readonly Dictionary<string, string> ValuesSubtitle = new() { { "pl", "Fundamenty, na których budujemy zaufanie" }, { "en", "Foundations on which we build trust" } };
        public static readonly Dictionary<string, string> TrustTitle = new() { { "pl", "Zaufanie" }, { "en", "Trust" } };
        public static readonly Dictionary<string, string> TrustText = new() { { "pl", "Uczciwoœæ i transparentnoœæ w ka¿dej transakcji." }, { "en", "Honesty and transparency in every transaction." } };
        public static readonly Dictionary<string, string> ProfessionalismTitle = new() { { "pl", "Profesjonalizm" }, { "en", "Professionalism" } };
        public static readonly Dictionary<string, string> ProfessionalismText = new() { { "pl", "Oferujemy kompleksow¹ obs³ugê na najwy¿szym poziomie." }, { "en", "We offer comprehensive service at the highest level." } };
        public static readonly Dictionary<string, string> PassionTitle = new() { { "pl", "Pasja" }, { "en", "Passion" } };
        public static readonly Dictionary<string, string> PassionText = new() { { "pl", "Kochamy to, co robimy." }, { "en", "We love what we do." } };
        public static readonly Dictionary<string, string> TeamTitle = new() { { "pl", "Nasz Zespó³" }, { "en", "Our Team" } };
        public static readonly Dictionary<string, string> TeamSubtitle = new() { { "pl", "Poznaj ekspertów, którzy pomog¹ Ci znaleŸæ wymarzon¹ nieruchomoœæ" }, { "en", "Meet the experts who will help you find your dream property" } };
        public static readonly Dictionary<string, string> YearsShort = new() { { "pl", "lat" }, { "en", "years" } };
        public static readonly Dictionary<string, string> OffersShort = new() { { "pl", "ofert" }, { "en", "deals" } };
    }

    public static class Common
    {
        public static readonly Dictionary<string, string> Currency = new() { { "pl", "z³" }, { "en", "PLN" } };
        public static readonly Dictionary<string, string> Area = new() { { "pl", "m?" }, { "en", "m?" } };
        public static readonly Dictionary<string, string> Rooms = new() { { "pl", "pokoje" }, { "en", "rooms" } };
        public static readonly Dictionary<string, string> RoomsShort = new() { { "pl", "pok." }, { "en", "rms" } };
        public static readonly Dictionary<string, string> Required = new() { { "pl", "*" }, { "en", "*" } };
    }

    public static class Footer
    {
        public static readonly Dictionary<string, string> Description = new() { { "pl", "Profesjonalne biuro obrotu nieruchomoœciami. Pomagamy znaleŸæ wymarzone miejsce do ¿ycia." }, { "en", "Professional real estate agency. We help find the dream place to live." } };
        public static readonly Dictionary<string, string> QuickLinks = new() { { "pl", "Szybkie linki" }, { "en", "Quick Links" } };
        public static readonly Dictionary<string, string> SearchOffers = new() { { "pl", "Wyszukiwarka ofert" }, { "en", "Property Search" } };
        public static readonly Dictionary<string, string> BlogAdvice = new() { { "pl", "Porady i blog" }, { "en", "Blog and Advice" } };
        public static readonly Dictionary<string, string> Contact = new() { { "pl", "Kontakt" }, { "en", "Contact" } };
        public static readonly Dictionary<string, string> Copyright = new() { { "pl", "© 2025 BetonoweZloto.pl. Wszelkie prawa zastrze¿one." }, { "en", "© 2025 BetonoweZloto.pl. All rights reserved." } };
    }

    public static class BlogPage
    {
        public static readonly Dictionary<string, string> Title = new() { { "pl", "Porady Ekspertów" }, { "en", "Expert Advice" } };
        public static readonly Dictionary<string, string> Subtitle = new() { { "pl", "Praktyczne wskazówki, aktualnoœci z rynku nieruchomoœci i przewodniki dla kupuj¹cych i sprzedaj¹cych" }, { "en", "Practical tips, real estate market news and guides for buyers and sellers" } };
        public static readonly Dictionary<string, string> Featured = new() { { "pl", "Wyró¿niony" }, { "en", "Featured" } };
        public static readonly Dictionary<string, string> ReadMore = new() { { "pl", "Czytaj wiêcej" }, { "en", "Read More" } };
        public static readonly Dictionary<string, string> MinRead = new() { { "pl", "min czytania" }, { "en", "min read" } };
        public static readonly Dictionary<string, string> NoArticles = new() { { "pl", "Brak artyku³ów" }, { "en", "No articles" } };
        public static readonly Dictionary<string, string> NoArticlesText = new() { { "pl", "W tej kategorii nie ma jeszcze artyku³ów" }, { "en", "There are no articles in this category yet" } };
        public static readonly Dictionary<string, string> CategoryPurchase = new() { { "pl", "Kupno" }, { "en", "Purchase" } };
        public static readonly Dictionary<string, string> CategorySale = new() { { "pl", "Sprzeda¿" }, { "en", "Sale" } };
        public static readonly Dictionary<string, string> CategoryLoan = new() { { "pl", "Kredyty" }, { "en", "Loans" } };
    }

    public static class ArticlePage
    {
        public static readonly Dictionary<string, string> BackToBlog = new() { { "pl", "Powrót do bloga" }, { "en", "Back to Blog" } };
        public static readonly Dictionary<string, string> Published = new() { { "pl", "Opublikowano:" }, { "en", "Published:" } };
        public static readonly Dictionary<string, string> ReadTime = new() { { "pl", "Czas czytania:" }, { "en", "Read time:" } };
        public static readonly Dictionary<string, string> Minutes = new() { { "pl", "minut" }, { "en", "minutes" } };
        public static readonly Dictionary<string, string> Author = new() { { "pl", "Autor" }, { "en", "Author" } };
        public static readonly Dictionary<string, string> TableOfContents = new() { { "pl", "Spis treœci" }, { "en", "Table of Contents" } };
        public static readonly Dictionary<string, string> ShareArticle = new() { { "pl", "Udostêpnij artyku³" }, { "en", "Share Article" } };
        public static readonly Dictionary<string, string> RelatedArticles = new() { { "pl", "Powi¹zane Artyku³y" }, { "en", "Related Articles" } };
        public static readonly Dictionary<string, string> NotFound = new() { { "pl", "Nie znaleziono artyku³u" }, { "en", "Article not found" } };
        public static readonly Dictionary<string, string> NotFoundText = new() { { "pl", "Artyku³ o podanym identyfikatorze nie istnieje lub zosta³ usuniêty." }, { "en", "The article with the given ID does not exist or has been removed." } };
    }
}
