// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_CDOInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_CDOInquiryService
  {
    [OperationContract]
    ResultStatus CDOInquiry_GetAllCDODefs(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus CDOInquiry_GetCDOs(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus CDOInquiry_GetFields(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus CDOInquiry_GetInstances(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Parameters parameters,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_CDOInquiryMethod[] methods,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_CDOInquiry v4_CDOInquiry,
      V4_CDOInquiry_Request request,
      out V4_CDOInquiry_Result result);
  }
}
