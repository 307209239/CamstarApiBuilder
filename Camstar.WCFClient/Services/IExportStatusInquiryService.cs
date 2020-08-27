// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExportStatusInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExportStatusInquiryService
  {
    [OperationContract]
    ResultStatus GetStatusDetails(
      UserProfile userProfile,
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Parameters parameters,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Parameters parameters,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExportStatusInquiryMethod[] methods,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExportStatusInquiry exportStatusInquiry,
      ExportStatusInquiry_Request request,
      out ExportStatusInquiry_Result result);
  }
}
