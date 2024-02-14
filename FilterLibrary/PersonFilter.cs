/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 3

namespace FilterLibrary
{
    public class PersonFilter
    {
        /************************************************************
         * Methods
         * *********************************************************/
        public IPerson[] FilterByFirstName(IPerson[] peopleToFilter,
                                           string firstName)
        {
            int validEntries = 0;

            IPerson[] filteredPeopleWithNulls = new IPerson[peopleToFilter.Length];

            foreach (IPerson currentPerson in peopleToFilter)
            {
                if (currentPerson != null && currentPerson.FirstName == firstName)
                {
                    filteredPeopleWithNulls[validEntries] = currentPerson;

                    ++validEntries;

                }

            }

            IPerson[] filteredPeople = new IPerson[validEntries];

            for (int i = 0; i < validEntries; ++i)
            {
                filteredPeople[i] = filteredPeopleWithNulls[i];

            }

            return filteredPeople;

        }

        public IPerson[] FilterByLastName(IPerson[] peopleToFilter,
                                          string lastName)
        {
            int validEntries = 0;

            IPerson[] filteredPeopleWithNulls = new IPerson[peopleToFilter.Length];

            foreach (IPerson currentPerson in peopleToFilter)
            {
                if (currentPerson != null && currentPerson.LastName == lastName)
                {
                    filteredPeopleWithNulls[validEntries] = currentPerson;

                    ++validEntries;

                }

            }

            IPerson[] filteredPeople = new IPerson[validEntries];

            for (int i = 0; i < validEntries; ++i)
            {
                filteredPeople[i] = filteredPeopleWithNulls[i];

            }

            return filteredPeople;

        }

        public IPerson[] FilterByAge(IPerson[] peopleToFilter,
                                     int age)
        {
            int validEntries = 0;

            IPerson[] filteredPeopleWithNulls = new IPerson[peopleToFilter.Length];

            foreach (IPerson currentPerson in peopleToFilter)
            {
                if (currentPerson != null && currentPerson.Age == age)
                {
                    filteredPeopleWithNulls[validEntries] = currentPerson;

                    ++validEntries;

                }

            }

            IPerson[] filteredPeople = new IPerson[validEntries];

            for (int i = 0; i < validEntries; ++i)
            {
                filteredPeople[i] = filteredPeopleWithNulls[i];

            }

            return filteredPeople;

        }

    }

}