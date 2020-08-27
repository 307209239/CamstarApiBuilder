// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IFilterTagInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IFilterTagInquiryService
  {
    [OperationContract]
    ResultStatus GetEmpFilterTags(
      UserProfile userProfile,
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);

    [OperationContract]
    ResultStatus GetEmpSessionFilterTags(
      UserProfile userProfile,
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);

    [OperationContract]
    ResultStatus GetFilterTags(
      UserProfile userProfile,
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Parameters parameters,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      FilterTagInquiryMethod[] methods,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      FilterTagInquiry filterTagInquiry,
      FilterTagInquiry_Request request,
      out FilterTagInquiry_Result result);
  }
}
