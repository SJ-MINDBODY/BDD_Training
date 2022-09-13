using System;
using TechTalk.SpecFlow;

namespace PetShop.StepDefinitions
{
    [Binding]
    public class PetshopStepDefinitions
    {
        [Given(@"I have base url '([^']*)' and resource with petid '([^']*)'")]
        public void GivenIHaveBaseUrlAndResourceWithPetid(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"I do get rquest")]
        public void WhenIDoGetRquest()
        {
            Console.WriteLine("get req");
        }

        [Then(@"I should get the response as (.*)")]
        public void ThenIShouldGetTheResponseAs(int p0)
        {
            Console.WriteLine(p0);

        }

        [Then(@"I should get message as '([^']*)'")]
        public void ThenIShouldGetMessageAs(string p0)
        {
            Console.WriteLine(p0);
        }

        [When(@"I do the Get Request")]
        public void WhenIDoTheGetRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"I should get a response as (.*)")]
        public void ThenIShouldGetAResponseAs(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I should get a message as '([^']*)'")]
        public void ThenIShouldGetAMessageAs(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I need to add api_key '([^']*)' in the header")]
        public void GivenINeedToAddApi_KeyInTheHeader(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I do delete rquest")]
        public void WhenIDoDeleteRquest()
        {
            throw new PendingStepException();
        }
    }
}
