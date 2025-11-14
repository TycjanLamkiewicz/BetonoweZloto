# BetonoweZloto.pl - Real Estate Agency Website

## ?? Overview
A comprehensive, modern website for BetonoweZloto.pl real estate agency built with Blazor and Tailwind CSS.

## ? Features

### ?? Design
- **Modern & Professional**: Clean, contemporary design with gold accent colors
- **Fully Responsive**: Mobile-first design that looks great on all devices
- **Accessible**: WCAG compliant with proper ARIA labels, keyboard navigation, and screen reader support
- **Performance Optimized**: Fast loading with lazy-loaded images and optimized assets

### ?? Pages & Components

#### ?? Home Page (`/`)
##### Hero Section
- Full-screen banner with attractive property image
- Compelling call-to-action buttons
- Smooth scroll indicator

##### About Section
- Company description and mission
- Three key features with icons:
  - 15+ years of experience
  - Professional team
  - Wide range of properties

##### Featured Properties
- Grid layout with 6 sample properties
- Each property card includes:
  - High-quality image
  - Price tag
  - Location
  - Area and room count
  - "View details" button

#### ?? Property Search Page (`/oferty`)
##### Advanced Search & Filters
- **Text Search**: Search by location, neighborhood, or address
- **Transaction Type Filter**: Sale or Rent
- **Property Type Filter**: Apartment, House, Plot, or Commercial
- **Price Range Filter**: Set maximum price
- **Area Filter**: Set minimum square meters
- **Advanced Filters** (expandable):
  - Number of rooms (1-5+)
  - Floor level
  - Year built (minimum)

##### Three View Modes
1. **Grid View**: Card-based layout with images and key details
2. **List View**: Detailed horizontal cards with more information
3. **Map View**: Interactive OpenStreetMap with property markers
   - Clickable markers with property previews
   - Automatic zoom to fit all results
   - Sidebar list of properties

##### Dynamic Filtering
- Real-time filtering of 12 sample properties
- Results counter
- Empty state with reset option
- All filters work together

##### Interactive Map
- **OpenStreetMap** integration via Leaflet.js
- Property markers with custom popups
- Click markers to see property details
- Automatic bounds adjustment
- Responsive map container

#### ?? About Us Page (`/o-nas`)
##### Company Story
- Detailed company history since 2009
- Mission statement and values
- Beautiful imagery and statistics
- 15+ years of experience highlighted

##### Key Statistics
- 500+ satisfied clients
- 800+ properties sold
- 15 years in business
- 98% recommendations

##### Company Values
- Trust - Honesty and transparency
- Professionalism - Continuous improvement
- Passion - Love for what we do

##### Team Section
- 6 professional real estate agents
- Each team member card includes:
  - Professional photo
  - Name and position
  - Specialization area
  - Years of experience
  - Properties sold count
  - Direct contact (phone & email) on hover
- Hover effects with contact buttons

#### ?? Blog & Advice Page (`/porady`)
##### Category Filters
- All articles
- Purchase advice
- Selling tips
- Mortgages & financing
- Investments
- Legal matters
- General advice

##### Featured Article
- Large hero card with the latest article
- Full-width image and detailed preview
- Author information with photo

##### Article Grid
- 9 sample articles across various categories
- Each article card shows:
  - Category badge
  - Publication date
  - Reading time estimate
  - Title and excerpt
  - Author name, role, and photo
  - "Read more" button
- Responsive grid layout (1-3 columns)

##### Newsletter Subscription
- Eye-catching signup form
- Email validation
- Success/error messages
- GDPR-friendly design

#### ?? Contact Page (`/kontakt`)
##### Quick Contact Methods
- Phone with business hours
- Email with response time
- Physical address with map link

##### Contact Form
- Full name (required)
- Email (required, validated)
- Phone number (required)
- Subject dropdown (required):
  - Want to buy
  - Want to sell
  - Looking for rent
  - Property valuation
  - Other question
- Message textarea (required, min 10 chars)
- GDPR consent checkbox (required)
- Form validation with inline errors
- Loading state during submission
- Success/error messages
- Accessible form labels and ARIA attributes

##### Interactive Map
- OpenStreetMap showing office location
- Custom marker with popup
- Office details in popup
- Link to Google Maps
- Responsive map container

##### Social Media Integration
- Large, branded social media buttons:
  - Facebook
  - Instagram
  - LinkedIn
- Links open in new tabs
- Accessible with proper labels

#### Navigation & Footer
##### Fixed Top Navigation
- Transparent backdrop blur effect
- Logo with hover animation
- Desktop menu with all pages
- Mobile hamburger menu
- Smooth scroll for anchor links
- Active page highlighting

##### Comprehensive Footer
- Company information section
- Quick links to all pages
- Contact details with icons
- Social media icon links:
  - Facebook
  - Instagram
  - LinkedIn
  - YouTube
- Copyright notice
- Hover effects on all links

### ?? Social Media Integration
- Prominent social media buttons on Contact page
- Social media icons in footer
- Consistent branding colors:
  - Facebook blue (#1877F2)
  - Instagram gradient
  - LinkedIn blue (#0A66C2)
  - YouTube red
- Proper external link handling
- Accessible labels for screen readers

### ? Accessibility Features
- Semantic HTML5 elements
- Proper heading hierarchy
- ARIA labels and roles
- Focus management and visible focus indicators
- Keyboard navigation support
- Color contrast compliance
- Non-breaking spaces for better text flow
- Reduced motion support
- Screen reader friendly form labels
- Touch-friendly targets (?44px)
- Form error announcements
- Descriptive link text

### ?? Mobile Optimization
- Touch-friendly button sizes (?44px)
- No disabled zoom
- Proper viewport meta tag
- Responsive grid layouts
- Hamburger menu for mobile
- Swipe-friendly cards
- Optimized map controls
- Stackable form fields

### ?? Technology Stack
- **Blazor Server** (.NET 10)
- **Tailwind CSS** (via CDN)
- **Leaflet.js** - Interactive maps
- **OpenStreetMap** - Map tiles (free, no API key)
- Custom Gold Theme - Matching the "Concrete Gold" brand
- Modern CSS with smooth animations
- Responsive images from Unsplash

## ?? Running the Project

1. Navigate to the project directory:
   ```bash
   cd BetonoweZloto
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

## ?? Sample Data

### Properties Database
The application includes 12 sample properties with realistic data:
- **Locations**: Warsaw, Kraków, Gdañsk, Wroc³aw, Poznañ, Katowice, Gdynia
- **Types**: Apartments, Houses, Plots, Commercial spaces
- **Transactions**: For sale and for rent
- **Price Range**: 420,000 PLN - 2,100,000 PLN (sale), 3,500 - 6,000 PLN/month (rent)
- **Area Range**: 35m? - 1,200m?
- **Features**: Rooms, year built, floor information
- **GPS Coordinates**: Real coordinates for map display

### Team Members
6 professional real estate agents:
- **Anna Kowalska** - Director, Premium properties specialist
- **Piotr Nowak** - Senior Agent, Single-family homes
- **Magdalena Wójcik** - Agent, Urban apartments
- **Tomasz Zieliñski** - Agent, Commercial properties
- **Katarzyna Lewandowska** - Junior Agent, First property buyers
- **Marcin Kamiñski** - Agent, Development investments

### Blog Articles
9 comprehensive articles covering:
- Buying your first property
- Preparing property for sale
- Mortgage guide
- Investment strategies
- Legal changes
- Home staging
- Market forecasts
- Negotiation tactics
- Primary vs secondary market

## ?? Color Scheme

- **Primary (Gold)**: #eab308 - Brand color for CTAs and accents
- **Gold Variants**: 50-900 scale for various UI elements
- **Dark**: #111827 - Text and dark backgrounds
- **Light**: #f9fafb - Light backgrounds and sections
- **White**: #ffffff - Cards and nav background
- **Social Media Colors**: Brand-specific colors for each platform

## ?? Contact Information (Sample)

- Phone: +48 123 456 789
- Email: kontakt@betonowezloto.pl
- Address: ul. Przyk³adowa 123, 00-001 Warszawa
- Hours: Mon-Fri 9:00-18:00, Sat 10:00-14:00

## ?? Site Structure

```
???????????????????????
?     Home (/)        ?  Landing page with hero, about, featured properties
???????????????????????
           ?
     ???????????????????????????????????????????????
     ?            ?          ?          ?          ?
???????????? ?????????? ????????? ?????????? ???????????
? Search   ? ? About  ? ? Blog  ? ?Contact ? ? (Future)?
?(/oferty) ? ?(/o-nas)? ?(/porady)?(/kontakt)?  Pages  ?
???????????? ?????????? ????????? ?????????? ???????????
```

## ?? Future Enhancements

### Phase 2 - Backend Integration
- [ ] Real property database
- [ ] User authentication system
- [ ] Admin panel for content management
- [ ] Property submission form for agents
- [ ] Automated email notifications
- [ ] API for mobile apps

### Phase 3 - Advanced Features
- [ ] Individual property detail pages
- [ ] Virtual 360° tours
- [ ] Photo galleries with lightbox
- [ ] User accounts and saved searches
- [ ] Favorite properties
- [ ] Property comparison tool
- [ ] Email alerts for new properties
- [ ] Mortgage calculator
- [ ] Neighborhood information
- [ ] School district data
- [ ] Public transport proximity
- [ ] Client testimonials section
- [ ] Multi-language support
- [ ] Dark mode
- [ ] Print-friendly property sheets

### Phase 4 - Marketing & Analytics
- [ ] SEO optimization
- [ ] Google Analytics integration
- [ ] Facebook Pixel
- [ ] Lead tracking
- [ ] A/B testing
- [ ] Email marketing integration
- [ ] CRM integration
- [ ] Live chat support

## ??? Map Features

### Current Implementation
- OpenStreetMap tiles via Leaflet.js
- Custom property markers
- Popup with property preview
- Automatic bounds fitting
- Zoom controls
- Touch-friendly on mobile
- Office location marker

### Possible Enhancements
- Cluster markers for better performance
- Custom marker icons by property type
- Draw search area on map
- Heatmap for property prices
- Nearby amenities (schools, shops, transport)
- Street view integration
- Satellite view option
- Distance measurement tool
- Property density overlay

## ?? Dependencies

- .NET 10 SDK
- Leaflet.js (loaded via CDN)
- OpenStreetMap tiles (free, no API key)
- Tailwind CSS (loaded via CDN)
- Unsplash (for stock images)
- Node.js and npm (optional, for custom Tailwind builds)

## ?? Code Structure

```
BetonoweZloto/
??? Components/
?   ??? Layout/
?   ?   ??? MainLayout.razor              # Main layout with nav, footer & social media
?   ?   ??? NavMenu.razor                 # (deprecated, nav moved to MainLayout)
?   ?   ??? ReconnectModal.razor          # Blazor reconnection modal
?   ??? Pages/
?   ?   ??? Home.razor                    # Landing page
?   ?   ??? PropertySearch.razor          # Search page with filters & map
?   ?   ??? About.razor                   # About us page with team
?   ?   ??? Blog.razor                    # Blog/advice page with articles
?   ?   ??? Contact.razor                 # Contact page with form & map
?   ?   ??? NotFound.razor                # 404 page
?   ?   ??? Counter.razor                 # (template - can be removed)
?   ??? _Imports.razor                    # Global using statements
?   ??? App.razor                         # Root component
??? wwwroot/
?   ??? app.css                           # Custom styles
?   ??? favicon.png                       # Site icon
??? Program.cs                            # Application entry point
??? package.json                          # NPM dependencies (optional)
??? tailwind.config.js                    # Tailwind configuration
??? README.md                             # This file
```

## ?? Testing Checklist

### Functionality
- [ ] All navigation links work
- [ ] Mobile menu opens/closes
- [ ] Property search filters work independently
- [ ] Property search filters work in combination
- [ ] Search text filters correctly
- [ ] View modes switch properly (Grid/List/Map)
- [ ] Maps display correctly
- [ ] Map markers are clickable
- [ ] Blog category filters work
- [ ] Newsletter form validates email
- [ ] Contact form validates all fields
- [ ] Contact form shows success message
- [ ] Social media links open in new tabs

### Accessibility
- [ ] Keyboard navigation works on all pages
- [ ] Focus indicators are visible
- [ ] Screen reader announces form errors
- [ ] All images have alt text
- [ ] Heading hierarchy is correct
- [ ] ARIA labels are present
- [ ] Color contrast meets WCAG AA
- [ ] Forms are properly labeled

### Responsive Design
- [ ] Desktop layout (1920px+)
- [ ] Laptop layout (1024px)
- [ ] Tablet layout (768px)
- [ ] Mobile layout (375px)
- [ ] Mobile menu works
- [ ] Touch targets are ?44px
- [ ] Maps resize correctly
- [ ] Images load properly

### Performance
- [ ] No console errors
- [ ] Smooth animations
- [ ] Images lazy load
- [ ] Maps load without errors
- [ ] Forms submit without delay
- [ ] No layout shifts (CLS)

### Cross-browser
- [ ] Chrome/Edge
- [ ] Firefox
- [ ] Safari
- [ ] Mobile Safari
- [ ] Mobile Chrome

## ?? License

© 2024 BetonoweZloto.pl. All rights reserved.

---

Built with ?? using Blazor, Tailwind CSS, and OpenStreetMap
