
 namespace Encog.ML {
	
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.IO;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// A machine learning method that is used to break data into clusters.  The 
	/// number of clusters is usually defined beforehand.  This differs from 
	/// the MLClassification method in that the data is clustered as an entire 
	/// group.  If additional data must be clustered later, the entire group 
	/// must be reclustered.
	/// </summary>
	///
	public interface MLClustering : MLMethod {
	
		/// <summary>
		/// Perform the training iteration.
		/// </summary>
		///
		void Iteration();
	
		/// <summary>
		/// Perform the specified number of training iterations.
		/// </summary>
		///
		/// <param name="count">The number of training iterations.</param>
		void Iteration(int count);
	
		
		/// <value>The clusters.</value>
		MLCluster[] Clusters {
		
		/// <returns>The clusters.</returns>
		  get;
		}
		
	
		
		/// <returns>The number of clusters.</returns>
		int NumClusters();
	}
}