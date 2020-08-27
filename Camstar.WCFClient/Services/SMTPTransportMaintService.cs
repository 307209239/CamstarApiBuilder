// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SMTPTransportMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SMTPTransportMaintService : DataTransportMaintBase
  {
    public SMTPTransportMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISMTPTransportMaintService), userProfile);
    }

    public ResultStatus Delete(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).Delete(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus Delete(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.Delete(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus Delete(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.Delete(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).Freeze(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus Freeze(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.Freeze(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus Freeze(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.Freeze(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).GetWIPMsgs(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.GetWIPMsgs(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.GetWIPMsgs(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).Load(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus Load(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.Load(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus Load(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.Load(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_LoadESigDetails_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).LoadESigDetails(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.LoadESigDetails, (SMTPTransportMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SMTPTransportMaint) null, (SMTPTransportMaint_LoadESigDetails_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.LoadESigDetails(sMTPTransportMaint, (SMTPTransportMaint_LoadESigDetails_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.LoadESigDetails(sMTPTransportMaint, (SMTPTransportMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).New(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus New(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.New(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus New(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.New(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).NewCopy(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus NewCopy(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.NewCopy(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus NewCopy(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.NewCopy(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).SaveAs(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus SaveAs(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.SaveAs(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus SaveAs(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.SaveAs(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Parameters parameters,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).UnFreeze(this._UserProfile, sMTPTransportMaint, parameters, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(sMTPTransportMaint, SMTPTransportMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) sMTPTransportMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SMTPTransportMaint) null, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(SMTPTransportMaint sMTPTransportMaint)
    {
      return this.UnFreeze(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SMTPTransportMaint sMTPTransportMaint,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.UnFreeze(sMTPTransportMaint, (SMTPTransportMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_LoadESigDetails_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.New((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.Load((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject sMTPTransportMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SMTPTransportMaint) sMTPTransportMaint, (SMTPTransportMaint_Parameters) parameters, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      try
      {
        SMTPTransportMaintMethod[] methods = new SMTPTransportMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISMTPTransportMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SMTPTransportMaint cdo,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      try
      {
        return ((ISMTPTransportMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SMTPTransportMaint) cdo, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.GetEnvironment((SMTPTransportMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SMTPTransportMaint cdo,
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      result = (SMTPTransportMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISMTPTransportMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SMTPTransportMaintMethod(cdo, SMTPTransportMaintMethods.ExecuteTransaction, (SMTPTransportMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SMTPTransportMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SMTPTransportMaint) cdo, (SMTPTransportMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SMTPTransportMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SMTPTransportMaint_Request) null, out SMTPTransportMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SMTPTransportMaint_Request request,
      out SMTPTransportMaint_Result result)
    {
      return this.ExecuteTransaction((SMTPTransportMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SMTPTransportMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SMTPTransportMaintMethod(cdo, SMTPTransportMaintMethods.AddDataTransaction, (SMTPTransportMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((SMTPTransportMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
