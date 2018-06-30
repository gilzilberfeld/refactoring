package pastamaker;

import static org.junit.Assert.*;

import org.approvaltests.Approvals;
import org.approvaltests.reporters.DiffReporter;
import org.approvaltests.reporters.UseReporter;
import org.junit.Test;

@UseReporter(DiffReporter.class)
public class PastaMakerTests {

	@Test
	public void pastaMakerExamples() {
		Approvals.verify("Say Spaghetti!");
	}
}
