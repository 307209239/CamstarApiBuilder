// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventCrossRefs_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UpdateEventCrossRefs_Environment : UpdateEventDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventCrossRefs_Environment_QualityCrossReferences")]
    [Metadata("New structure for CrossReference processing.", "QualityCrossReferenceDetail", false, false, false, "QualityCrossReferenceDetail", 1052980, false, true, false, null)]
    protected QualityCrossReferenceDetail_Environment _QualityCrossReferences;

    public QualityCrossReferenceDetail_Environment QualityCrossReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReferences), (object) value);
      }
      get
      {
        return (QualityCrossReferenceDetail_Environment) this.PropertyGet(nameof (QualityCrossReferences));
      }
    }
  }
}
