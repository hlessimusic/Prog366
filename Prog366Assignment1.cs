//Always executes in the same time/space regardless of the size of the input data set.
int Constant(IList<int> list)
{
	// Will always add one to first element in the input list, regardless of list size. Constant runtime.
    return list[0] + 1;
}


//Performance grows linearly and in direct proportion to the size of the input data set.
bool  Linear(IList<int> list, int value)
{
	// iterate over list. Linear runtime.
    foreach (var entry in list)
    {
        if (entry >= value) return true;
    }

    return false;
}


//Performance is directly proportional to the square of the size of the input data set.
bool Quadratic(IList<int> list)
{

    for (var i = 0; i < elements.Count; i++)
    {
    	//Outer For loop, sets i index. Linear runtime.
        for (var j = 0; j < elements.Count; j++)
        {
        	//Inner For loop, sets j index. Quadratic runtime.

            // Don't compare with self
            if (i == j) continue;

            if (list[i] / list[j] == 0.5) return true;
        }
    }

    return false;
}