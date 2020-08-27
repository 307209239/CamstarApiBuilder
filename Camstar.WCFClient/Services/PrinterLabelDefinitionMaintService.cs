// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrinterLabelDefinitionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrinterLabelDefinitionMaintService : RevisionedObjectMaintBase
  {
    public PrinterLabelDefinitionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrinterLabelDefinitionMaintService), userProfile);
    }

    public ResultStatus Delete(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).Delete(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus Delete(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.Delete(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus Delete(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.Delete(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.DeleteAllRevisions(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.DeleteAllRevisions(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).Freeze(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus Freeze(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.Freeze(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus Freeze(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.Freeze(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.GetWIPMsgs(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.GetWIPMsgs(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).Load(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus Load(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.Load(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus Load(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.Load(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_LoadESigDetails_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).LoadESigDetails(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.LoadESigDetails, (PrinterLabelDefinitionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_LoadESigDetails_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.LoadESigDetails(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_LoadESigDetails_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.LoadESigDetails(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).New(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus New(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.New(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus New(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.New(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).NewCopy(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.NewCopy(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.NewCopy(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).NewRev(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus NewRev(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.NewRev(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus NewRev(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.NewRev(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).NewRevCopy(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.NewRevCopy(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.NewRevCopy(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).SaveAs(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.SaveAs(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.SaveAs(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).SaveAsRev(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.SaveAsRev(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.SaveAsRev(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Parameters parameters,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).UnFreeze(this._UserProfile, printerLabelDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(printerLabelDefinitionMaint, PrinterLabelDefinitionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) printerLabelDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PrinterLabelDefinitionMaint) null, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint)
    {
      return this.UnFreeze(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PrinterLabelDefinitionMaint printerLabelDefinitionMaint,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.UnFreeze(printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_LoadESigDetails_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.New((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Load((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printerLabelDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrinterLabelDefinitionMaint) printerLabelDefinitionMaint, (PrinterLabelDefinitionMaint_Parameters) parameters, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      try
      {
        PrinterLabelDefinitionMaintMethod[] methods = new PrinterLabelDefinitionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrinterLabelDefinitionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrinterLabelDefinitionMaint cdo,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      try
      {
        return ((IPrinterLabelDefinitionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PrinterLabelDefinitionMaint) cdo, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.GetEnvironment((PrinterLabelDefinitionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrinterLabelDefinitionMaint cdo,
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      result = (PrinterLabelDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrinterLabelDefinitionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(cdo, PrinterLabelDefinitionMaintMethods.ExecuteTransaction, (PrinterLabelDefinitionMaint_Parameters) null));
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
        PrinterLabelDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrinterLabelDefinitionMaint) cdo, (PrinterLabelDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrinterLabelDefinitionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PrinterLabelDefinitionMaint_Request) null, out PrinterLabelDefinitionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrinterLabelDefinitionMaint_Request request,
      out PrinterLabelDefinitionMaint_Result result)
    {
      return this.ExecuteTransaction((PrinterLabelDefinitionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrinterLabelDefinitionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrinterLabelDefinitionMaintMethod(cdo, PrinterLabelDefinitionMaintMethods.AddDataTransaction, (PrinterLabelDefinitionMaint_Parameters) null));
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
        return this.AddDataTransaction((PrinterLabelDefinitionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
