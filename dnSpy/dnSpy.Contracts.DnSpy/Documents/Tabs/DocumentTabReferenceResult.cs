﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace dnSpy.Contracts.Documents.Tabs {
	/// <summary>
	/// Created by <see cref="IReferenceDocumentTabContentProvider"/>
	/// </summary>
	public sealed class DocumentTabReferenceResult {
		/// <summary>
		/// New tab content, never null
		/// </summary>
		public DocumentTabContent DocumentTabContent { get; }

		/// <summary>
		/// Serialized UI data for <see cref="DocumentTabContent"/> or null if none
		/// </summary>
		public object SerializedUI { get; }

		/// <summary>
		/// Called when the output has been shown, can be null
		/// </summary>
		public Action<ShowTabContentEventArgs> OnShownHandler { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="documentTabContent">New content</param>
		/// <param name="serializedUI">Serialized UI data or null</param>
		/// <param name="onShownHandler">Handler or null</param>
		public DocumentTabReferenceResult(DocumentTabContent documentTabContent, object serializedUI = null, Action<ShowTabContentEventArgs> onShownHandler = null) {
			if (documentTabContent == null)
				throw new ArgumentNullException(nameof(documentTabContent));
			this.DocumentTabContent = documentTabContent;
			this.SerializedUI = serializedUI;
			this.OnShownHandler = onShownHandler;
		}
	}
}
