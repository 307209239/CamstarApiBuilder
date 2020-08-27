// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistActualResponse_Environment
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
  public class ChecklistActualResponse_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistActualResponse_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Defines the response entry within Response Set.", "ResponseItem", false, false, true, "SubentityRef", 1052433, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistActualResponse_Environment_ResponseItem")]
    protected Environment _ResponseItem;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment ResponseItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseItem));
      }
    }
  }
}
