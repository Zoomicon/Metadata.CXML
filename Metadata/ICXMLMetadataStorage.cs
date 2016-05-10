//Project: Metadata.CXML (https://github.com/zoomicon/Metadata.CXML)
//Filename: ICXMLMetadataStorage
//Version: 20160510

using System.Collections.Generic;

namespace Metadata.CXML
{

  public interface ICXMLMetadataStorage<T>: IDictionary<string, T> where T: ICXMLMetadata
  {
  }

}
