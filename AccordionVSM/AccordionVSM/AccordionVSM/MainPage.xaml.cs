using Syncfusion.XForms.Accordion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AccordionVSM
{
    public partial class MainPage : ContentPage
    {
        SfAccordion accordion;
        public MainPage()
        {
            InitializeComponent();
            //InitializeAccordionItems();
            //this.Content = accordion;
        }

        private void InitializeAccordionItems()
        {
            accordion = new SfAccordion();
            accordion.Items.Add(GenerateAccordionItem());
        }

        public AccordionItem GenerateAccordionItem()
        {
            var item = new AccordionItem();
            item.Header = new Label() { Text = "Cheese burger" };
            item.Content = new Label() { Text = "Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." };
            VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
            VisualStateGroup commonStateGroup = new VisualStateGroup();

            VisualState expanded = new VisualState
            {
                Name = "Expanded"
            };
            expanded.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundColorProperty, Value = Color.Red });
            expanded.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundColorProperty, Value = Color.Red });

            VisualState collapsed = new VisualState
            {
                Name = "Collapsed"
            };
            collapsed.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundColorProperty, Value = Color.Green });
            collapsed.Setters.Add(new Setter { Property = AccordionItem.HeaderBackgroundColorProperty, Value = Color.Green });

            commonStateGroup.States.Add(expanded);
            commonStateGroup.States.Add(collapsed);

            visualStateGroupList.Add(commonStateGroup);
            VisualStateManager.SetVisualStateGroups(item, visualStateGroupList);
            return item;
        }
    }
}
