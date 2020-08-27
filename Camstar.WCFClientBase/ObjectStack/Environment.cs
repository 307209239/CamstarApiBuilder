// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Environment
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Environment : WCFObjectBase
  {
    [DataMember(EmitDefaultValue = false, Name = "SelectionValues")]
    public RecordSet SelectionValues { get; set; }

    public override bool IsEmpty
    {
      get
      {
        if (!base.IsEmpty)
          return false;
        return this.SelectionValues == null || this.SelectionValues.Headers == null;
      }
    }

    public static MetadataAttribute GetMetadata(string fieldExpression)
    {
      MetadataAttribute metadataAttribute = (MetadataAttribute) null;
      if (!string.IsNullOrEmpty(fieldExpression))
      {
        try
        {
          string[] strArray1 = fieldExpression.Split('.');
          FieldInfo fieldInfo = (FieldInfo) null;
          if (strArray1.Length > 1)
          {
            string str = strArray1[0] + "_Environment";
            Type type = Type.GetType(string.Format("Camstar.WCF.ObjectStack.{0}, Camstar.WCFClient", (object) str));
            if (type == (Type) null)
              throw new WCFServiceException(":" + str + "Type '{0}' doesn`t exist.");
            for (int index = 1; index < strArray1.Length; ++index)
            {
              string[] strArray2 = strArray1[index].Split(':');
              string name = strArray2[0];
              if (strArray2.Length > 1)
              {
                type = Type.GetType(string.Format("Camstar.WCF.ObjectStack.{0}, Camstar.WCFClient", (object) (strArray2[1] + "_Environment")));
                if (type == (Type) null)
                  throw new WCFServiceException(":" + strArray2[1] + "Type '{0}' doesn`t exist.");
              }
              else
              {
                fieldInfo = WCFObjectBase.GetField(type, name);
                type = fieldInfo.FieldType;
              }
            }
          }
          if (fieldInfo != (FieldInfo) null)
            metadataAttribute = fieldInfo.GetCustomAttributes(typeof (MetadataAttribute), false)[0] as MetadataAttribute;
        }
        catch (WCFServiceException ex)
        {
          throw new WCFServiceException(string.Format("Invalid path for '({0}).{1}' expression. {2}", (object) fieldExpression.Substring(0, fieldExpression.IndexOf('.')), (object) fieldExpression.Substring(fieldExpression.IndexOf('.') + 1), (object) ex.Message));
        }
      }
      return metadataAttribute;
    }
  }
}
