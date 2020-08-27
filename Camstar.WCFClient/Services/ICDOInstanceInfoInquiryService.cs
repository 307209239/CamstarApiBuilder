// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICDOInstanceInfoInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICDOInstanceInfoInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Parameters parameters,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Parameters parameters,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CDOInstanceInfoInquiryMethod[] methods,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CDOInstanceInfoInquiry cDOInstanceInfoInquiry,
      CDOInstanceInfoInquiry_Request request,
      out CDOInstanceInfoInquiry_Result result);
  }
}
