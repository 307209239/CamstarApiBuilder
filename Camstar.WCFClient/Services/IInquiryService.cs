﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Inquiry inquiry,
      Inquiry_Parameters parameters,
      Inquiry_Request request,
      out Inquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      InquiryMethod[] methods,
      Inquiry_Request request,
      out Inquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Inquiry inquiry,
      Inquiry_Request request,
      out Inquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Inquiry inquiry,
      Inquiry_Request request,
      out Inquiry_Result result);
  }
}
