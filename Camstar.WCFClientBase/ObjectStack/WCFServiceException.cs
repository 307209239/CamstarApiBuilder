// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WCFServiceException
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;

namespace Camstar.WCF.ObjectStack
{
  public class WCFServiceException : Exception
  {
    public WCFServiceException()
    {
    }

    public WCFServiceException(string message)
      : base(message)
    {
    }

    public WCFServiceException(Exception e)
      : base(e.Message + " (see inner exception for more information)", e)
    {
    }
  }
}
