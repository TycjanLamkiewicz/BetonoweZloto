# BetonoweZloto.pl - Real Estate Agency Website

## ?? Overview
A modern, professional website for BetonoweZloto.pl real estate agency built with Blazor and Tailwind CSS.

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

#### Navigation
- Fixed top navigation bar with blur effect
- Logo with hover animation
- Desktop and mobile menu
- Smooth scrolling to sections
- Active page highlighting

#### Footer
- Company information
- Quick links
- Contact details
- Copyright notice

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

### ?? Mobile Optimization
- Touch-friendly button sizes (?44px)
- No disabled zoom
- Proper viewport meta tag
- Responsive grid layouts
- Hamburger menu for mobile
- Swipe-friendly cards
- Optimized map controls

### ?? Technology Stack
- **Blazor Server** (.NET 10)
- **Tailwind CSS** (via CDN)
- **Leaflet.js** - Interactive maps
- **OpenStreetMap** - Map tiles
- Custom Gold Theme - Matching the "Concrete Gold" brand
- Modern CSS with smooth animations

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

### Map Integration
- Properties are displayed with accurate GPS coordinates
- Markers show property previews on click
- Automatic grouping and zoom adjustment
- Free OpenStreetMap tiles (no API key required)

## ?? Color Scheme

- **Primary (Gold)**: #eab308 - Brand color for CTAs and accents
- **Gold Variants**: 50-900 scale for various UI elements
- **Dark**: #111827 - Text and dark backgrounds
- **Light**: #f9fafb - Light backgrounds and sections
- **White**: #ffffff - Cards and nav background

## ?? Contact Information (Sample)

- Phone: +48 123 456 789
- Email: kontakt@betonowezloto.pl
- Address: ul. Przyk³adowa 123, 00-001 Warszawa

## ?? Future Enhancements

Consider adding:
- Individual property detail pages
- Contact form with validation
- Favorite/saved properties
- Property comparison tool
- Virtual 360° tours
- Photo galleries with lightbox
- User accounts and saved searches
- Email alerts for new properties
- Mortgage calculator
- Neighborhood information
- School district data
- Public transport proximity
- Client testimonials section
- Blog/news section
- Social media integration
- Multi-language support
- Dark mode
- Print-friendly property sheets

## ??? Map Features

### Current Implementation
- OpenStreetMap tiles via Leaflet.js
- Custom property markers
- Popup with property preview
- Automatic bounds fitting
- Zoom controls
- Touch-friendly on mobile

### Possible Enhancements
- Cluster markers for better performance
- Custom marker icons by property type
- Draw search area on map
- Heatmap for property prices
- Nearby amenities (schools, shops, transport)
- Street view integration
- Satellite view option

## ?? Dependencies

- .NET 10 SDK
- Leaflet.js (loaded via CDN)
- OpenStreetMap tiles (free, no API key)
- Tailwind CSS (loaded via CDN)
- Node.js and npm (optional, for custom Tailwind builds)

## ?? Code Structure

```
BetonoweZloto/
??? Components/
?   ??? Layout/
?   ?   ??? MainLayout.razor        # Main layout with nav & footer
?   ?   ??? NavMenu.razor           # (deprecated, nav moved to MainLayout)
?   ?   ??? ReconnectModal.razor    # Blazor reconnection modal
?   ??? Pages/
?   ?   ??? Home.razor              # Landing page
?   ?   ??? PropertySearch.razor    # Search page with filters & map
?   ?   ??? NotFound.razor          # 404 page
?   ?   ??? Counter.razor           # (template - can be removed)
?   ??? _Imports.razor              # Global using statements
?   ??? App.razor                   # Root component
??? wwwroot/
?   ??? app.css                     # Custom styles
?   ??? favicon.png                 # Site icon
??? Program.cs                      # Application entry point
??? README.md                       # This file
```

## ?? Testing Checklist

- [ ] All filters work independently
- [ ] Filters work in combination
- [ ] Search text filters correctly
- [ ] View modes switch properly
- [ ] Map displays all properties
- [ ] Map markers are clickable
- [ ] Mobile menu works
- [ ] Responsive on all screen sizes
- [ ] Keyboard navigation works
- [ ] Focus indicators visible
- [ ] Screen reader compatible
- [ ] No console errors
- [ ] Smooth animations (respecting prefers-reduced-motion)
- [ ] Links work correctly
- [ ] Form inputs are accessible

## ?? License

© 2024 BetonoweZloto.pl. All rights reserved.
