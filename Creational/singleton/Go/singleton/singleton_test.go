package singleton

import "testing"

func TestGetInstance(t *testing.T) {
	counter := GetInstance()

	if counter == nil {
		t.Error("Expected pointer to singleton after calling Getinstance(), not nil \n")
	}

	counter.AddOne();
	
	if counter.count != 1 {
		t.Errorf("Couter must be 1 but foundi %d\n", counter.count)
	}

	secondCounter := GetInstance()

	if counter != secondCounter {
		t.Error("Expected same in instance in second counter but it got a different instance")
	}
}
