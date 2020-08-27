// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EMailDistributionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EMailDistributionMaintService : NamedDataObjectMaintBase
  {
    public EMailDistributionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEMailDistributionMaintService), userProfile);
    }

    public ResultStatus Delete(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).Delete(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus Delete(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.Delete(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus Delete(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.Delete(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).Freeze(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus Freeze(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.Freeze(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus Freeze(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.Freeze(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.GetWIPMsgs(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.GetWIPMsgs(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).Load(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus Load(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.Load(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus Load(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.Load(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_LoadESigDetails_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).LoadESigDetails(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.LoadESigDetails, (EMailDistributionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EMailDistributionMaint) null, (EMailDistributionMaint_LoadESigDetails_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.LoadESigDetails(eMailDistributionMaint, (EMailDistributionMaint_LoadESigDetails_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.LoadESigDetails(eMailDistributionMaint, (EMailDistributionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).New(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus New(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.New(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus New(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.New(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).NewCopy(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus NewCopy(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.NewCopy(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus NewCopy(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.NewCopy(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).SaveAs(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus SaveAs(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.SaveAs(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus SaveAs(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.SaveAs(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Parameters parameters,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).UnFreeze(this._UserProfile, eMailDistributionMaint, parameters, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(eMailDistributionMaint, EMailDistributionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eMailDistributionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EMailDistributionMaint) null, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus UnFreeze(EMailDistributionMaint eMailDistributionMaint)
    {
      return this.UnFreeze(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EMailDistributionMaint eMailDistributionMaint,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.UnFreeze(eMailDistributionMaint, (EMailDistributionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_LoadESigDetails_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.New((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.Load((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eMailDistributionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailDistributionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EMailDistributionMaint) eMailDistributionMaint, (EMailDistributionMaint_Parameters) parameters, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      try
      {
        EMailDistributionMaintMethod[] methods = new EMailDistributionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEMailDistributionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EMailDistributionMaint cdo,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      try
      {
        return ((IEMailDistributionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EMailDistributionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EMailDistributionMaint) cdo, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.GetEnvironment((EMailDistributionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EMailDistributionMaint cdo,
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      result = (EMailDistributionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailDistributionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EMailDistributionMaintMethod(cdo, EMailDistributionMaintMethods.ExecuteTransaction, (EMailDistributionMaint_Parameters) null));
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
        EMailDistributionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EMailDistributionMaint) cdo, (EMailDistributionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EMailDistributionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EMailDistributionMaint_Request) null, out EMailDistributionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EMailDistributionMaint_Request request,
      out EMailDistributionMaint_Result result)
    {
      return this.ExecuteTransaction((EMailDistributionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EMailDistributionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EMailDistributionMaintMethod(cdo, EMailDistributionMaintMethods.AddDataTransaction, (EMailDistributionMaint_Parameters) null));
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
        return this.AddDataTransaction((EMailDistributionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
