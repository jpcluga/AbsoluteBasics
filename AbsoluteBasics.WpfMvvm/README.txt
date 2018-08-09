(1) Run Visual Studio as "Administrator".
    Rebuild the solution. package.config will download everything you
    need to run the application. If Build Succeeds, ignore the errors
    if there is any from Visual Studio, the app should be ready to run
    without any compile time errors. Restart if needed.    

(2) Read the comments in the code. You may get started to dig deeper
    just by having the ideas of how it works fundamentally.

(3) Adding new ViewModels
   3.1 Create A new class under ViewModel Folder
   3.2 Inherit from the 'ViewModelBase' class; resolve if missing reference
   3.3 Register the new ViewModel in ViewModelLocator constructor
   3.4 Create a new property that will return an object of your new ViewModel

(4) Further readings:
    ICommands
    http://www.technical-recipes.com/2016/using-relaycommand-icommand-to-handle-events-in-wpf-and-mvvm/

    ObservableCollection
    https://www.c-sharpcorner.com/UploadFile/e06010/observablecollection-in-wpf/
